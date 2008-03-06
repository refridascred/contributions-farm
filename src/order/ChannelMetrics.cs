using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value ^ tally) < tally) && (10.0 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
