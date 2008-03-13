using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up profile order samples.</summary>
        public static long MatchProfileOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3093;
        public const long CacheToken = 2037;
        public const long CacheSize = 6699;
        public const double WindowToken = 42.34;
        public const string HardToken = "latest-v2";

        /// <summary>Roll a layout route counter forward.</summary>
        public static long DeriveLayoutRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix * 4) + (step / 9);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict-v2";
        public const long StepBuffer = 4121;
        public const long CacheScore = 1428;
        public const long DefaultBuffer = 118;
    }
}
