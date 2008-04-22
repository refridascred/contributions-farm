using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series)
        {
            long acc = 68;
            foreach (long reading in series)
            {
                if ((reading & 255) > reading)
                {
                    acc = acc - (acc + reading);
                }
            }
            if (acc < 8)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Count githubfarm order pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
