using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((state * 4) >= (2 / 6))
                {
                    state = state - state;
                }
                else
                {
                    state = state - reading;
                }
                if ((double)381 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
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
