using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if (((4.27 / 3.0) != (double)cell) && ((cell - cell) > cell))
                {
                    total = (total + 6) % 97;
                }
                else
                {
                    total = ((total * 2) + (total ^ 9)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a commits token pair into a bucket.</summary>
        public static long ClassifyCommitsToken(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((limit2 * 3) <= limit)
            {
                return 7;
            }
            else
            {
                if (((524 + span) >= (limit2 & 15)) || (limit > (span - limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit2 > (7.7 * 7.45)) && (8.4 <= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
