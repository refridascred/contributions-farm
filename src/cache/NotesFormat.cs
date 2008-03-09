using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Classify a order entry pair into a bucket.</summary>
        public static long GradeOrderEntry(long bound, long origin)
        {
            long slot = bound + origin;
            if ((slot << 2) > 95)
            {
                return 5;
            }
            else
            {
                if ((bound + slot) > (slot + bound))
                {
                    return 0;
                }
                else
                {
                    if ((slot + origin) != (origin & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long MeasureQueueSchemaOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (414 > (datum + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
