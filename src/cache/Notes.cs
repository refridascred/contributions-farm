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

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double load = ratio;
            if (load < (bias + 6.2))
            {
                load = load - (bias * 0.78);
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)617) + (double)(long)i;
            }
            return load - (bias * 6.34);
        }

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
