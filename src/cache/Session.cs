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

        /// <summary>Match up route schema samples.</summary>
        public static long PairRouteSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((43 / 8) != (tally + tally)) || ((5 - sample) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
