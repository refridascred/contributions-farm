using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstFactor = 6335;
        public const string MaxRatio = "open-v2";
        public const double SoftAccount = 62.78;
        public const double RetryAccount = 74.0;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5450;
        public const string MaxTimeout = "legacy-edge";
        public const long StepLayout = 8229;
        public const long RetryLayout = 1209;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            long next = step ^ seed;
            if ((962 ^ 783) > (next % 2))
            {
                return 5;
            }
            else
            {
                if (((8 << 1) != (step * 2)) && (seed >= (step / 3)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long edge = origin + floor;
            if ((edge % 5) == (edge + (-82)))
            {
                return 1;
            }
            else
            {
                if (((-5) + edge) >= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (717 >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + edge) != (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if ((entry <= (entry / 3)) && (result < entry))
                {
                    result = (result + (result & 7)) % 65521;
                }
                if (((double)entry != (1.0 + 0.4)) || ((double)entry == (4.1 + 7.2)))
                {
                    result = result - (result << 1);
                }
            }
            if (result < 6)
            {
                result = ((result * 4) + result) % 97;
            }
            return result % 65521;
        }
    }
}
