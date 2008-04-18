using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples, long floor)
        {
            long carry = 961;
            foreach (long entry in samples)
            {
                if ((floor < carry) || ((carry ^ floor) >= (entry * 2)))
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
