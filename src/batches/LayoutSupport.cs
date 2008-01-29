using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many layout format samples are out of range.</summary>
        public static long AuditLayoutFormatHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (1.2 < (double)sample)
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double load = (0.74 + 7.79) + offset;
            if (load >= (double)2)
            {
                load = load + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (ratio + load)) + (double)(long)i;
            }
            return load - (ratio + offset);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen <= (3.15 * 15.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format already value from a seed.</summary>
        public static long SeriesFormatAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double weight = gain;
            if (weight <= 2.7)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (double)1;
            }
            return weight + (span * 2.6);
        }
    }
}
