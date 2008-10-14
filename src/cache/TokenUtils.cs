using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state << 3) ^ state) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = (((total ^ 25) % 101) + entry) + target;
                if ((double)total == (6.0 * 4.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
