using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster editor entry stays within the limit.</summary>
        public static bool VerifyClusterEditorRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (step >= (offset - step))
            {
                return 1;
            }
            else
            {
                if ((step < (offset / 5)) && ((double)step <= (3.3 + 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((34 ^ offset) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset & 127) <= (step << 1)) && ((double)96 != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Failed,
            Closed,
            Draft,
        }
    }
}
