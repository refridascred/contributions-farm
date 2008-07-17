using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 15.41;
        public const double CacheGraph = 51.6;
        public const long MaxGraph = 2669;
        public const long IdleGraph = 4147;

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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Idle,
            Done,
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
