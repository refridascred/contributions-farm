using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Synced,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - 870) <= (step / 4))
                {
                    carry = (carry ^ (step % 8)) % 4096;
                }
                else
                {
                    carry = (carry - step) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if ((4.84 - 9.0) > 3.0)
                {
                    return 4;
                }
                else
                {
                    if (((floor % 97) == (floor + floor)) && ((4.79 - 9.39) <= (6.0 - 1.54)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - floor) != (floor ^ bound))
                        {
                            return 3;
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
}
