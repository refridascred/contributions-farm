using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes order samples.</summary>
        public static long DigestNotesOrder(long[] values)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (datum >> 3)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed + (-417)) >= (65 % 10))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length & 127) != (673 ^ entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
