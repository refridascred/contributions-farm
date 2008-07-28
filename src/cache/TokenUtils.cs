using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long anchor = 9;
            foreach (long sample in data)
            {
                if (((anchor + sample) != (step % 8)) && (sample >= (step - step)))
                {
                    anchor = anchor + (8 << 1);
                }
                if (step >= (long)data.Length)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a profile batch pair into a bucket.</summary>
        public static long ClassifyProfileBatch(long floor, long floor2)
        {
            if (floor < (floor2 + floor2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) < floor2)
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 6.0) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor2 >= (4.7 - 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
