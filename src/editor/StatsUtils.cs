using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool ValidateRecordPayloadBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = (result - bound) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const double MinBooking = 76.73;
        public const double BaseRatio = 16.66;
        public const string CacheFactor = "fallback-edge";

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
