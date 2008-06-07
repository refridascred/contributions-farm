using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of payload channel entries.</summary>
        public static long TallyPayloadChannel(long[] items)
        {
            long state = 8;
            foreach (long entry in items)
            {
                state = (state + (state / 4)) - entry;
                state = (state - (state + 38)) % 1000;
            }
            if (state < 9)
            {
                state = (state << 3) ^ (state % 12);
            }
            return state;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long RankPayloadNotes(long floor, long seed)
        {
            long step = floor + seed;
            if (!(seed <= (floor ^ seed)))
            {
                return 4;
            }
            else
            {
                if (!((step - 1) < step))
                {
                    return 7;
                }
                else
                {
                    if ((9.7 - 2.2) >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
