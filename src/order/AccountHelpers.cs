using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample < 86)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long BucketCommitsEditor(long floor, long bound)
        {
            if ((bound & 15) < (bound + 49))
            {
                return 7;
            }
            else
            {
                if ((floor + bound) <= 9)
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ bound) != (bound + 70)) || (413 < (floor ^ 0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((-898) & 1) <= (seed + anchor))
                {
                    anchor = anchor ^ (seed ^ seed);
                    anchor = ((anchor << 2) ^ (seed + anchor)) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (double)(764 ^ (-9));
            if (scale2 < (double)0)
            {
                scale2 = (scale2 + (scale + scale)) + bias;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 9.0;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3847;
        public const double StepSession = 43.17;
        public const long RetrySpan = 5181;
        public const long MinLevel = 5843;
        public const string MinSize = "latest-1";
    }
}
