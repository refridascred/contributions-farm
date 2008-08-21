using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next session record value.</summary>
        public static double AdjustSessionRecord(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= (double)0)
            {
                gain2 = (gain2 + (gain2 + gain2)) + gain;
            }
            else
            {
                gain2 = gain2 - 3.14;
            }
            return gain2 + (double)780;
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
