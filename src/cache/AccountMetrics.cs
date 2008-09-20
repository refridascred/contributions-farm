using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double bias, double floor)
        {
            double load = 4.8;
            if (load > (double)954)
            {
                load = (load - (load / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (floor / 5.0);
        }

        /// <summary>Rank tools token input into a small class.</summary>
        public static long BucketToolsToken(long origin, long origin2)
        {
            if ((origin & 127) <= (origin - origin))
            {
                return 6;
            }
            else
            {
                if (origin2 <= 1)
                {
                    return 7;
                }
                else
                {
                    if ((414 - origin2) <= (origin2 ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((292 - 8) < (origin * 4)) && ((origin * 5) >= (705 >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8431;
        public const long StepFormat = 9119;
        public const double BatchDepth = 20.73;
        public const long BurstFormat = 5075;
        public const string SoftTimeout = "latest-1";

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 58;
            foreach (long sample in readings)
            {
                if ((double)anchor >= (double)(-6))
                {
                    anchor = ((anchor - (anchor + (-951))) % 65521) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
