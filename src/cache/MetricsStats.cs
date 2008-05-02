using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            New,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next format channel value.</summary>
        public static double ScaleFormatChannel(double scale, double bias)
        {
            double gain = (double)(18 << 1);
            if (gain <= scale)
            {
                gain = gain - (gain + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long IterateSchemaAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (target >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) < (item % 24))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
