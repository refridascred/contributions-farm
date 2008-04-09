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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length != (double)cell) || !(cell <= (611 + 450)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
