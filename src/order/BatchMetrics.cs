using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item > (7.9 * 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.3 + 1.6) < (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheRatio = 3138;
        public const long HardContext = 4996;
        public const long StepContext = 9918;
        public const string DefaultContext = "strict-1";
        public const string MinContext = "staging";
    }
}
