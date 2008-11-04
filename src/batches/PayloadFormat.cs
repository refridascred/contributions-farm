using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i >> 2) < (result + 13)))
                {
                    result = (result * 3) + (long)i;
                }
                result = (result - (result & 3)) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 7806;
        public const string WindowAccount = "fallback-edge";
        public const double MinScore = 44.23;
        public const long BurstAccount = 190;
        public const long BatchCount = 5136;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally >> 4) <= (413 << 3)) || ((3 % 64) > (entry + tally))) || (((315 << 1) != ((long)readings.Length + tally)) && ((double)floor < (0.1 / 4.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
