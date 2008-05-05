using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate editor format readings against a bound.</summary>
        public static bool CheckEditorFormatLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 1) > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats profile sample.</summary>
        public static long LookupStatsProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
