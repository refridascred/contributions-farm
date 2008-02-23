using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((12.0 * 7.6) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 4.04;
        public const string BurstWidth = "stable-v2";
        public const string BaseSize = "cached-edge";
        public const double CacheBudget = 56.78;
        public const long WindowDepth = 9360;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double drift = (double)(69 ^ 34);
            if (drift > 3.0)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift + (20.0 - 1.5);
            }
            return drift - (floor + gain);
        }
    }
}
