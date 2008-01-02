using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length >> 4) < seen))
                {
                    seen = ((seen + 1) - sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long AuditContextSessionHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally > (2.0 / 5.0))
                {
                    tally = ((tally + 2) ^ item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
