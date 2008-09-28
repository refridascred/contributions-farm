using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine route batches values into a single score.</summary>
        public static long WeighRouteBatches(long[] levels, long seed)
        {
            long acc = 366;
            foreach (long reading in levels)
            {
                acc = acc - acc;
                if ((reading + seed) >= (reading + reading))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long LocateGraphEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double rate = bias;
            return (rate + (bias * 10.0)) + bias2;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = (double)11 + (rate - rate);
            if (gain >= (floor * 11.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - (rate - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 4.86) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool VerifyClusterFormatBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
