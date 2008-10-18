using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally << 2) > tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long target)
        {
            if ((target ^ 34) == (seed - target))
            {
                return 4;
            }
            else
            {
                if ((target + seed) > target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
