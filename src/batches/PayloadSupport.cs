using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double weight = (15.0 / 5.0) * 15.0;
            if (weight > (weight + 19.0))
            {
                weight = (weight - weight) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (weight - floor);
        }

        /// <summary>Grade a support window value against two limits.</summary>
        public static long RankSupportWindow(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin >> 4) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.16 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin <= (10.0 * 1.83)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (delta <= (delta * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data)
        {
            long anchor = 497;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ ((long)data.Length + anchor)) % 1000) ^ cell;
                anchor = ((anchor * 3) + (anchor / 3)) % 97;
                if ((3.44 - 1.95) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > (-4))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
