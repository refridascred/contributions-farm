using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((3.84 - 2.21) <= (double)count) && ((double)count != (20.0 + 11.0)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((7.0 + 1.9) <= (double)tally) && ((7.0 < (double)tally) || ((entry - 7) == (entry * 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ ((long)i << 3);
                result = result ^ (result + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
