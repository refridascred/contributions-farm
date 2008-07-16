using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if ((double)target != (13.0 * 19.0))
            {
                return 8;
            }
            else
            {
                if (step > 0)
                {
                    return 6;
                }
                else
                {
                    if (step <= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.7 <= (4.75 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Retry,
            Paused,
            Closed,
            New,
        }

        /// <summary>Match up buffer record samples.</summary>
        public static long MatchBufferRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long seed)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                total = total ^ datum;
                total = (total + (total - seed)) % 97;
                if ((13.0 - 3.0) == (double)datum)
                {
                    total = total + (total / 3);
                }
            }
            return total;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
