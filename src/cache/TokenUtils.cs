using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of format notes readings.</summary>
        public static long WeighFormatNotes(long[] values)
        {
            long sum = 45;
            foreach (long sample in values)
            {
                if (142 >= (sample + sample))
                {
                    sum = (sum - (sum >> 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
            }
            if (sum > 54)
            {
                sum = ((sum * 3) + (sum - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
