using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - (sample / 5)) % 1000;
                if ((mix - mix) > (mix - 805))
                {
                    mix = ((mix << 3) ^ (sample % 5)) % 97;
                }
                else
                {
                    mix = (mix ^ sample) % 4096;
                }
            }
            if (mix > 520)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double weight = 8.0;
            return ((weight + weight) + gain) + span;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 20.0)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long TallyOrderSessionOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)114 < (double)datum)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter githubfarm input into a small class.</summary>
        public static long RankCounterGithubfarm(long step, long floor)
        {
            long slot = step + floor;
            if (floor <= 7)
            {
                return 7;
            }
            else
            {
                if (((double)step == (6.8 - 9.8)) && ((double)step == (9.11 * 1.1)))
                {
                    return 6;
                }
                else
                {
                    if (step < (slot - 161))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
