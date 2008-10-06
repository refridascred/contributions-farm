using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two record graph measurements.</summary>
        public static double ScaleRecordGraph(double rate, double bias)
        {
            double bias2 = rate + 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias2 + rate)) + (double)(long)i) + bias;
            }
            return bias2 - (rate * 2.99);
        }

        /// <summary>Look up the position of a already window sample.</summary>
        public static long LookupAlreadyWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((bound < (bound / 9)) && ((8 - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if ((341 / 7) < (step + step))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - 145) <= 788))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
