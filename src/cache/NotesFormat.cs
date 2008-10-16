using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((hits >> 3) > reading) || ((hits * 3) > (hits / 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
