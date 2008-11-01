using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long seed)
        {
            if ((seed * 3) != (seed - seed))
            {
                return 0;
            }
            else
            {
                if (((seed * 2) == (offset + seed)) || (seed > (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed < (10.0 + 0.1)) && (offset < (seed >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.84 / 8.0) <= (double)seed) && (seed < (319 + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long CompareChecksProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
