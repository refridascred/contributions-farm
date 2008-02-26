using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (double)88)
            {
                ratio = (ratio + (double)7) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)74) + (double)(long)i;
            }
            return ratio + (double)36;
        }

        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double SmoothStreamPayload(double scale, double bias)
        {
            double gain = (double)(3 - 267);
            if (gain >= (double)(-46))
            {
                gain = gain + bias;
            }
            return gain - (scale - gain);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((tally + sample) >= (sample + sample)) || ((sample + 2) != (tally - sample))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long step)
        {
            if (step < (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 1.14) <= (1.9 + 17.0))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (origin * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step >= (double)3))
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
    }
}
