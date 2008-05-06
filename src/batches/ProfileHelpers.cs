using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long DigestProfileContributi(long[] levels)
        {
            long result = 371;
            foreach (long reading in levels)
            {
                if (reading > (result ^ reading))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if (cell >= (628 - 8))
                {
                    mark = (mark * 5) + (cell >> 4);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double ratio = (double)97 * 4.7;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (6.9 * 3.25);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long floor)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                if ((double)result != (double)85)
                {
                    result = (((result << 2) ^ (result % 12)) - datum) - floor;
                }
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed - step;
            if (!((double)step >= (6.0 - 4.48)))
            {
                return 2;
            }
            else
            {
                if ((step % 10) == (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (0.85 - 4.0)) || ((seed + lane) < (step + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-729) - step) > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
