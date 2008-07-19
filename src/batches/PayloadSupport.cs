using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mix = 99;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long target)
        {
            if ((double)target > (1.59 * 9.81))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (7.7 + 18.0))
                {
                    return 6;
                }
                else
                {
                    if ((7 - bound) >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound < (0.5 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 85.12;
        public const string IdleBatches = "primary-1";
        public const long LimitBatches = 1167;
        public const long MaxCount = 9339;
        public const double SoftSize = 45.83;
    }
}
