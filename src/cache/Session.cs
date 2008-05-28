using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context counter samples are out of range.</summary>
        public static long AuditContextCounterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((40 % 24) == (entry + 1))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if ((48 < (step << 3)) || ((step ^ (long)i) >= result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Failed,
            Ready,
            Queued,
        }
    }
}
