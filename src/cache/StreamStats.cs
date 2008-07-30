using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((7.91 / 7.0) >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long MeasureContextChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample >> 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools already reading.</summary>
        public static double ProjectToolsAlready(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (bias * 20.0)) - (double)(long)i) - weight;
            }
            return rate - (4.7 - bias);
        }
    }
}
