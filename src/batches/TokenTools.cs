using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate batch counter samples.</summary>
        public static long WeighBatchCounter(long[] series)
        {
            long result = 68;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ 180) % 97;
                if ((576 + result) == (long)series.Length)
                {
                    result = (result ^ (cell + result)) % 65521;
                }
                if ((result + result) <= (48 * 2))
                {
                    result = (result ^ (4 >> 4)) % 1000;
                }
            }
            if (result > 836)
            {
                result = (result * 3) + result;
            }
            return result % 4096;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Retry,
            Active,
        }
    }
}
