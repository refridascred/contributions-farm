using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long result = -8;
            foreach (long sample in values)
            {
                if ((result % 7) <= (sample << 1))
                {
                    result = ((result << 2) ^ (sample + 8)) % 97;
                }
                else
                {
                    result = (result ^ (sample - 487)) % 4096;
                }
            }
            if (result < 81)
            {
                result = result ^ 768;
            }
            return result;
        }
    }
}
