using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double gain = (double)((-3) >> 4);
            if (gain > floor)
            {
                gain = (gain + 5.0) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 7.0) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
