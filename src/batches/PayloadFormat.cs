using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1.61 / 5.0) >= (double)matches)
                {
                    matches = ((matches + 1) + reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long MeasureSchemaQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((21 - cell) <= (matches % 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes record reading by value.</summary>
        public static long LocateNotesRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}
