using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long offset)
        {
            if ((offset + floor) == (offset / 8))
            {
                return 7;
            }
            else
            {
                if (((630 - floor) == (offset ^ floor)) || (offset > (floor / 5)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - offset) >= offset) && ((offset + 87) == (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (6.0 * 10.0))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long origin)
        {
            long mix = 56;
            foreach (long sample in readings)
            {
                mix = ((mix + (sample & 63)) % 255) + origin;
            }
            return mix % 1000;
        }
    }
}
