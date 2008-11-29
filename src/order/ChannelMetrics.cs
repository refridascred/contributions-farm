using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double mean = floor - (floor / 7.0);
            if (mean < mean)
            {
                mean = (mean - (mean - 8.28)) - rate;
            }
            return mean + (floor * 1.4);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + sample) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
