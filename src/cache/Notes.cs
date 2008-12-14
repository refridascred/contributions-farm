using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long total = 22;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total - (73 & 63)) % 255) - (long)i) ^ reading;
                }
                total = (total << 2) ^ (945 + 49);
                total = total ^ total;
            }
            if (total < (-202))
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double span)
        {
            double ratio = (6.6 + span) / 9.0;
            if (ratio > bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            return ratio + (19.0 / 7.0);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if ((value % 8) <= (value * 4))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (value << 1);
                }
            }
            return sum % 97;
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long DigestMetricBuffer(long[] series, long step)
        {
            long mix = 9;
            foreach (long value in series)
            {
                mix = (mix + ((-3) + value)) - step;
            }
            return mix % 97;
        }
    }
}
