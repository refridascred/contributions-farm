using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum ^ (834 * 4)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 2374;
        public const long StepCache = 801;
        public const long DefaultSpan = 2320;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if ((double)acc < 9.38)
                {
                    acc = ((acc + (acc / 4)) % 255) ^ reading;
                }
                else
                {
                    acc = (acc + (origin - 4)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
