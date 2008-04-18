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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Queued,
            Pending,
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
