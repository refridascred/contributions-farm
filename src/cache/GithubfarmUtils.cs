using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many context buffer samples are out of range.</summary>
        public static long CountContextBufferHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (step < (count - step))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            New,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
