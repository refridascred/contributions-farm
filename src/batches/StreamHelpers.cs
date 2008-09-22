using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double drift = bias;
            if (drift < (double)867)
            {
                drift = drift + 1.7;
            }
            else
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 - (gain + gain)) + (double)(long)i) - floor;
            }
            return gain2 - gain2;
        }

        /// <summary>Accumulate session graph samples.</summary>
        public static long CombineSessionGraph(long[] series)
        {
            long mix = 515;
            foreach (long entry in series)
            {
                if (!((entry / 5) < (65 + mix)))
                {
                    mix = (mix ^ (entry & 63)) % 101;
                }
                if ((mix >> 3) == ((long)series.Length % 8))
                {
                    mix = (mix + entry) % 1000;
                }
                else
                {
                    mix = (mix * 3) + (entry * 4);
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((19.0 - 7.3) != (double)tally)
                {
                    tally = ((tally + 3) - reading) - offset;
                }
            }
            return tally;
        }
    }
}
