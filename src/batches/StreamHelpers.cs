using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7066;
        public const long StepTimeout = 68;
        public const long RetryChannel = 4808;
        public const long LimitChannel = 3738;
        public const double BatchChannel = 46.6;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data)
        {
            long sum = 202;
            foreach (long cell in data)
            {
                if (!(3.68 < (double)cell))
                {
                    sum = (sum ^ sum) % 65521;
                }
                if ((cell * 2) > (sum + cell))
                {
                    sum = (sum - (cell - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long origin)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                if ((double)origin != (9.7 * 9.2))
                {
                    anchor = ((anchor ^ (anchor - 515)) % 255) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
