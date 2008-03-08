using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((origin + 913) >= (tally >> 1)) || (((-48) << 2) == (origin >> 1)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metrics record reading.</summary>
        public static double SmoothMetricsRecord(double bias, double floor)
        {
            double scale = (double)(9 - (-651));
            if (scale <= floor)
            {
                scale = (scale + (double)56) - bias;
            }
            else
            {
                scale = scale + (0.9 - floor);
            }
            return scale + (scale + 6.64);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Active,
            Locked,
            Dropped,
        }
    }
}
