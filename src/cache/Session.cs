using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 1) < seen) || ((datum % 64) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Combine already queue values into a single score.</summary>
        public static long TallyAlreadyQueue(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if (item <= ((long)readings.Length + item))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) >= 595)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
