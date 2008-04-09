using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 4683;
        public const string CacheQueue = "local";
        public const long MaxRatio = 6509;
        public const double MaxScore = 0.63;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((1 ^ (long)data.Length) <= (tally / 7)) || !((double)target < 9.4))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long TallyEditorOrderGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (tally - tally)) || ((origin - tally) < reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ (result + bound)) % 4096;
                result = (result * 5) + (bound / 6);
                result = (result * 4) + (bound + (long)i);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
