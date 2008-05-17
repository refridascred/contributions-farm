using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long offset2)
        {
            long delta = offset - offset2;
            if (offset >= (delta + (-6)))
            {
                return 5;
            }
            else
            {
                if (((offset + offset) <= delta) || (((-878) / 5) < (delta % 7)))
                {
                    return 8;
                }
                else
                {
                    if (((offset2 + offset) >= (delta / 4)) && ((offset2 ^ delta) <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset2 < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 3) ^ step) % 97;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            if (!((double)bound != (9.63 - 2.33)))
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (6.05 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (8.4 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - seed) > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
