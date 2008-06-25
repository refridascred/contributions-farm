using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of support command readings.</summary>
        public static long TallySupportCommand(long[] series, long target)
        {
            long carry = 279;
            foreach (long item in series)
            {
                if ((double)(long)series.Length >= (3.15 + 8.0))
                {
                    carry = ((carry ^ (target << 3)) % 101) + item;
                }
                else
                {
                    carry = ((carry * 2) + (target + 37)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "cached-v2";
        public const string BaseSize = "legacy-v2";
        public const long RetryFilter = 7461;
        public const long MinFilter = 3482;
    }
}
