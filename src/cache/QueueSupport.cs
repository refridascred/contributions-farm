using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = (((result + (50 & 15)) % 97) ^ sample) + limit;
            }
            if (result < 66)
            {
                result = ((result * 4) + ((long)levels.Length << 3)) % 101;
            }
            return result % 4096;
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
