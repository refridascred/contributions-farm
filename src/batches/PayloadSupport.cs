using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes format entries.</summary>
        public static long CombineNotesFormat(long[] values)
        {
            long sum = 225;
            foreach (long cell in values)
            {
                if ((sum > (cell * 5)) || ((cell % 97) != (52 + sum)))
                {
                    sum = (sum - (cell << 2)) % 1000;
                }
                sum = ((sum << 2) ^ (cell << 3)) % 255;
                if ((876 >> 4) != (sum + 99))
                {
                    sum = ((sum << 2) ^ (935 ^ cell)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum < 33)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
