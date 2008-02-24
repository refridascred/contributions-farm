using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count - count) == ((-186) >> 1)) && ((count - count) > (9 * 4))) && (count <= (item << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                if ((offset >> 1) > offset)
                {
                    mix = ((mix - (offset + mix)) % 4096) + value;
                }
                if (!(((long)samples.Length - offset) == (mix ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) <= (cell & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long DigestChannelWindow(long[] values, long origin)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((35 % 24) < (result % 97))
                {
                    result = ((result * 5) + ((long)values.Length / 7)) - item;
                }
                if (((origin + origin) < (97 ^ origin)) || (result >= ((-7) + origin)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit counter payload readings against a rule.</summary>
        public static long TallyCounterPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell > (cell % 24)) || (cell < tally)) && ((tally + cell) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
