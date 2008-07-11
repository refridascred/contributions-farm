using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - ((long)i / 5);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            long delta = target ^ offset;
            if (((delta + 571) < (offset * 4)) || ((double)target < 4.58))
            {
                return 7;
            }
            else
            {
                if ((double)target <= 7.0)
                {
                    return 2;
                }
                else
                {
                    if (((offset ^ delta) < (42 + 609)) || ((double)target > (2.2 * 5.27)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6 << 3) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine already tools values into a single score.</summary>
        public static long WeighAlreadyTools(long[] values, long bound)
        {
            long carry = -3;
            foreach (long entry in values)
            {
                if (!((carry & 127) != (entry % 2)))
                {
                    carry = carry ^ (bound + (long)values.Length);
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 33;
            foreach (long item in values)
            {
                if (!((double)state >= (6.0 - 2.5)))
                {
                    state = (state ^ (item ^ state)) % 4096;
                }
            }
            if (state < 758)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryTimeout = "open-edge";
        public const double CacheStats = 22.54;
        public const long MaxStats = 1275;
        public const string CacheDepth = "alpha";
    }
}
