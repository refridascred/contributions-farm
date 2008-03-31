using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank support record input into a small class.</summary>
        public static long RankSupportRecord(long origin, long floor)
        {
            long bound = origin + floor;
            if ((floor / 4) < bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((origin / 3) < (floor + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a report profile figure with a bias.</summary>
        public static double AdjustReportProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate - 3.79) + offset;
        }
    }
}
