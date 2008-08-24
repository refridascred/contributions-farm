using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 52;
            foreach (long entry in samples)
            {
                carry = carry + (9 ^ carry);
                if ((entry - carry) != (6 & 7))
                {
                    carry = ((carry * 2) + carry) % 101;
                }
                else
                {
                    carry = (carry * 5) + (3 << 2);
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long target)
        {
            if ((target & 3) < (target + step))
            {
                return 6;
            }
            else
            {
                if (((247 - 84) > target) || ((step & 1) == (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 3) == (2 + 690))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.0 - 1.5) > 0.2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
