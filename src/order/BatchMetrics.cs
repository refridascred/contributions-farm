using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry >= ((long)data.Length + (long)data.Length))
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)(-6))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
