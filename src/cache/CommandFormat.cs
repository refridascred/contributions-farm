using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings)
        {
            long sum = 305;
            foreach (long reading in readings)
            {
                sum = ((sum ^ (sum * 5)) % 65521) - reading;
            }
            if (sum > 953)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}
