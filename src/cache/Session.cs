using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(((long)series.Length & 1) >= seen))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long AuditBufferEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
