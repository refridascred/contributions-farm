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

        /// <summary>Roll a graph command counter forward.</summary>
        public static long RollGraphCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i <= 9.8)
                {
                    acc = ((acc << 2) ^ (step + (long)i)) % 1000;
                    continue;
                }
                acc = (acc + (step % 100)) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
