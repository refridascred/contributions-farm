using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values)
        {
            long result = 98;
            foreach (long cell in values)
            {
                if (!((9.06 - 7.0) > (double)cell))
                {
                    result = (result * 2) + (result - result);
                }
                if ((cell / 7) <= cell)
                {
                    break;
                }
            }
            if (result < 459)
            {
                result = ((result * 5) + (long)values.Length) % 101;
            }
            return result;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            long lane = floor + step;
            if (step < (lane - lane))
            {
                return 0;
            }
            else
            {
                if ((7.12 - 2.5) < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((floor / 4) != (lane << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + lane) > (floor << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already tools reading.</summary>
        public static double SmoothAlreadyTools(double rate, double offset)
        {
            double weight = (rate + rate) / 4.0;
            if (weight >= (double)8)
            {
                weight = weight + weight;
            }
            return weight + offset;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long mix = 166;
            foreach (long entry in data)
            {
                mix = (((mix * 5) + (mix >> 4)) % 1000) - bound;
                if ((entry >> 5) >= (entry >> 4))
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - 997)) % 1000;
                }
            }
            if (mix < 30)
            {
                mix = ((mix << 2) ^ (7 / 5)) % 1000;
            }
            return mix;
        }
    }
}
