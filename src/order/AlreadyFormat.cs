using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches stream value from a seed.</summary>
        public static long StepBatchesStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 2) + (offset * 4);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long MeasureCounterContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count > ((long)series.Length - offset)) && ((count & 1) > count)) || (((count ^ cell) != (74 << 2)) && (420 >= (count + 7))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
