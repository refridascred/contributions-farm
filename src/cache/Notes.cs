using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 75;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark ^ floor) % 1000) - (long)i) ^ sample;
                }
                if (mark >= ((-837) + floor))
                {
                    mark = (mark << 2) ^ (floor & 1);
                }
                else
                {
                    mark = (mark + (floor / 4)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Scale a token contributi figure with a bias.</summary>
        public static double ProjectTokenContributi(double bias, double floor)
        {
            double mean = floor;
            if (mean > (floor * 6.4))
            {
                mean = mean + (floor * 1.6);
            }
            return mean - (mean + bias);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long target)
        {
            if ((double)step < 4.0)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (8.55 * 7.33)) || ((step + target) >= (4 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (!((target & 15) >= (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 1) != (target * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
