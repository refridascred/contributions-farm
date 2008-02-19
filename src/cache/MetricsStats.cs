using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next account layout value.</summary>
        public static double ScaleAccountLayout(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (double)(-89)) + (double)(long)i) - floor;
            }
            return gain + (double)32;
        }

        /// <summary>Match up report farm samples.</summary>
        public static long OverlapReportFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((sample + seen) >= sample) || (((long)items.Length % 64) == (sample & 15))) && ((sample - seen) >= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((double)bound < (double)(long)i)
                {
                    acc = (acc ^ (bound + bound)) % 4096;
                    acc = (acc * 3) + (bound - acc);
                }
                if ((bound > (bound + (long)i)) || ((double)acc != (3.1 + 13.0)))
                {
                    acc = acc ^ ((long)i ^ 35);
                }
                acc = ((acc * 4) + (bound + acc)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
