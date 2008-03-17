using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - bias;
            }
            return bias + (bias + rate);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            New,
            Synced,
            Idle,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a report session figure with a bias.</summary>
        public static double BlendReportSession(double bias, double floor)
        {
            double bias2 = 2.0;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = (bias2 - (double)97) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
