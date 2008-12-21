using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + (mix >> 1);
                if (bound >= (mix % 8))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = mix ^ (mix ^ mix);
                }
                if (mix > (bound >> 1))
                {
                    mix = ((mix << 3) ^ (bound / 3)) % 1000;
                    mix = ((mix << 2) ^ (mix + mix)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
