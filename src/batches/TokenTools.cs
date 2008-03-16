using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long score = 1;
            foreach (long sample in data)
            {
                if ((2.4 / 3.0) != (double)offset)
                {
                    score = (score * 3) + (sample & 1);
                }
                else
                {
                    score = (score * 4) + (score >> 5);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((double)step2 < (20.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (step2 < (step ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((11 & 1) == (floor - step2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
