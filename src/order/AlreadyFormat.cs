using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout command value.</summary>
        public static double AdjustLayoutCommand(double bias, double offset)
        {
            double scale = (double)(128 - 63);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (bias + scale)) + (double)(long)i) - offset;
            }
            return scale - bias;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (double)634)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)173;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (5.21 - scale)) + (double)(long)i;
            }
            return scale - (double)582;
        }

        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long TallyChannelMetricsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum & 1) >= datum))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Stale,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
