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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 21;
            foreach (long value in levels)
            {
                if ((value & 7) > (value ^ value))
                {
                    state = state ^ (62 + 1);
                }
                if ((double)state != (19.0 / 2.0))
                {
                    break;
                }
            }
            return state;
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
