using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long offset)
        {
            if (!((double)offset != (4.6 - 7.0)))
            {
                return 5;
            }
            else
            {
                if ((offset < (586 % 100)) || (floor >= offset))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 2) < (floor % 24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits metric entries.</summary>
        public static long TallyCommitsMetric(long[] levels)
        {
            long result = -2;
            foreach (long datum in levels)
            {
                result = (result - 2) + datum;
            }
            return result;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long DeriveTokenBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                if ((state >= (state >> 2)) && ((87 & 3) > step))
                {
                    state = ((state << 3) ^ step) % 4096;
                    state = state - (step % 5);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 6361;
        public const long LimitSize = 1097;
        public const long BaseSpan = 3725;
        public const long SoftSpan = 5935;
        public const long IdleDepth = 2864;
    }
}
