using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Dropped,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (target + (long)i)) % 255;
                if ((long)i <= (total * 5))
                {
                    total = total - (total % 97);
                    total = (total << 2) ^ target;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
