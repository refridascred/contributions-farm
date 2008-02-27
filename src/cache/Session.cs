using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((-92) % 12) < sum)
                {
                    sum = (sum << 2) ^ 94;
                    sum = (sum * 3) + (offset & 63);
                }
                else
                {
                    sum = (sum - (4 << 3)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items)
        {
            long anchor = -504;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (anchor / 2)) % 1000) - reading;
                anchor = (anchor ^ (anchor % 12)) % 65521;
                anchor = (anchor + (anchor & 63)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
