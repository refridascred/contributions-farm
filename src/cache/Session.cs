using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + value) >= (limit % 3)) && (limit < (tally + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Scale a record profile figure with a bias.</summary>
        public static double SmoothRecordProfile(double bias, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight * 8.3)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
