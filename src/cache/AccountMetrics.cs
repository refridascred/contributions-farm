using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) == (sample & 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((double)state < (2.0 / 6.0))
                {
                    state = state + ((long)readings.Length % 10);
                }
                if ((state - datum) >= (datum + (long)readings.Length))
                {
                    state = state - datum;
                }
                else
                {
                    state = (state ^ (6 - state)) % 101;
                }
            }
            if (state < 463)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 956;
        public const long MaxChannel = 2969;
        public const double MinChannel = 38.62;
        public const double BatchChannel = 0.97;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window tools pair into a bucket.</summary>
        public static long GradeWindowTools(long offset, long seed)
        {
            long diff = offset - seed;
            if ((seed % 64) > seed)
            {
                return 2;
            }
            else
            {
                if ((diff + seed) != (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if (((20.0 * 8.0) != (double)diff) || ((double)seed >= (6.82 + 4.19)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((9.2 - 2.0) >= (double)seed) && ((9 + diff) > (diff / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 2012;
        public const long BaseFarm = 6952;
        public const long MinFarm = 2489;
        public const long WindowFarm = 7325;
    }
}
