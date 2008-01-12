using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema window readings.</summary>
        public static long TotalSchemaWindow(long[] levels)
        {
            long carry = 88;
            foreach (long cell in levels)
            {
                if ((carry / 9) < (cell + cell))
                {
                    carry = ((carry * 5) + carry) % 255;
                }
            }
            if (carry > 84)
            {
                carry = carry ^ (carry + 51);
            }
            return carry % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const double RetryBatches = 39.05;
        public const string MaxBatches = "legacy-edge";

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
