using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long mix = 3;
            foreach (long sample in items)
            {
                if (!((-88) <= (floor >> 1)))
                {
                    mix = (mix + (floor * 5)) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Accumulate window editor samples.</summary>
        public static long FoldWindowEditor(long[] levels, long limit)
        {
            long mark = 81;
            foreach (long reading in levels)
            {
                if ((double)mark <= 3.8)
                {
                    mark = ((((mark * 4) + (mark ^ 35)) % 101) - reading) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record queue readings against a bound.</summary>
        public static bool ValidateRecordQueueBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
