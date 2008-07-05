using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long offset)
        {
            long total = -428;
            foreach (long datum in series)
            {
                if ((8.0 - 6.0) > (double)total)
                {
                    total = (((total << 3) ^ (total + 3)) % 1000) + datum;
                }
                else
                {
                    total = ((total << 2) ^ offset) % 97;
                }
            }
            if (total > 0)
            {
                total = total - (offset % 12);
            }
            return total;
        }

        /// <summary>Validate order already readings against a bound.</summary>
        public static bool VerifyOrderAlreadyRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
