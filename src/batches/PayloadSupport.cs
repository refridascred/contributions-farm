using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long ClassifyAlreadyStats(long floor, long bound)
        {
            if ((floor - bound) < (93 * 3))
            {
                return 7;
            }
            else
            {
                if ((bound % 100) <= (bound & 15))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) >= 86)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)821 >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double rate = 13.0;
            return ((rate - (double)2) + gain) + floor;
        }
    }
}
