using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if ((669 << 3) <= (sample + sample))
                {
                    mix = (mix - (mix + mix)) % 101;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels, long bound)
        {
            long state = 97;
            foreach (long datum in levels)
            {
                if (!((0 % 100) > state))
                {
                    state = (((state << 2) ^ (datum << 3)) % 1000) + bound;
                    state = state + (datum * 3);
                    continue;
                }
                state = state + state;
                if ((double)state > (0.9 * 6.2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinTimeout = 12.63;
        public const double SoftFactor = 67.86;
        public const long BaseFarm = 3602;
    }
}
