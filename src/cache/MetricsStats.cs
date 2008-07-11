using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data, long step)
        {
            long acc = -117;
            foreach (long entry in data)
            {
                acc = ((acc ^ step) % 255) ^ entry;
                if (((step + acc) >= (acc & 127)) || ((59 & 3) <= (10 - step)))
                {
                    acc = (acc - step) % 101;
                }
            }
            if (acc > 36)
            {
                acc = (acc - 48) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix << 3)) % 65521) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Project the next tools context value.</summary>
        public static double BlendToolsContext(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (bias * 7.3)) - (double)(long)i) - bias2;
            }
            return load - 2.0;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit <= (975 ^ limit))
                {
                    break;
                }
                mark = ((mark * 2) + 7) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
