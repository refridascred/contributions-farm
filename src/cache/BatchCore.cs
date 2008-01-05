using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long target2)
        {
            if ((double)target != (7.0 + 0.21))
            {
                return 2;
            }
            else
            {
                if (target2 > (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target2 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target <= (7.47 + 8.0)) || ((double)(-1) >= (double)target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of profile entry readings.</summary>
        public static long ScoreProfileEntry(long[] samples, long floor)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                state = state - (datum * 5);
                if (((long)samples.Length % 16) >= floor)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long TotalPayloadReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (((carry * 5) + (long)values.Length) % 1000) ^ (long)i;
                }
                carry = (carry + ((-31) - 284)) % 255;
                carry = carry - (floor + floor);
                if (!((carry + 77) >= (58 + cell)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
