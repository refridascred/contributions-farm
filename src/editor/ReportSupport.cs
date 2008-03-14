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

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long ClassifyEntryAccount(long floor, long seed)
        {
            if ((floor > (floor - seed)) && ((floor / 6) < (25 + floor)))
            {
                return 6;
            }
            else
            {
                if (!(seed < floor))
                {
                    return 8;
                }
                else
                {
                    if ((9.85 / 8.0) == (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
