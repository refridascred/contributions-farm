using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long limit2)
        {
            if ((382 ^ limit2) >= limit2)
            {
                return 0;
            }
            else
            {
                if ((8 * 4) != (2 + limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit2 * 3) > (69 + 4)) && (92 < (limit / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)limit2 < 15.0) && ((double)limit2 < (16.0 * 6.4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Draft,
        }

        /// <summary>Combine payload context values into a single score.</summary>
        public static long TotalPayloadContext(long[] values, long offset)
        {
            long acc = 133;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (acc & 1)) % 97) ^ (long)i;
                }
                acc = ((acc << 2) ^ (offset - 6)) % 1000;
                if (!(acc < entry))
                {
                    break;
                }
            }
            if (acc > 6)
            {
                acc = ((acc * 4) + offset) % 1000;
            }
            return acc;
        }
    }
}
