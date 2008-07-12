using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long offset, long bound)
        {
            if ((bound > offset) || ((double)offset < (8.8 + 4.83)))
            {
                return 6;
            }
            else
            {
                if ((double)offset > (double)47)
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ bound) >= (offset - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > (7.13 - 3.1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long LookupGithubfarmToolsIndex(long[] samples, long floor)
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

        /// <summary>Roll a schema format counter forward.</summary>
        public static long RollSchemaFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + result)) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
