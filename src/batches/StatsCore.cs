using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit + matches) > matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 12) == (sample & 15))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = (sum - (701 ^ reading)) % 65521;
            }
            if (sum < 2)
            {
                sum = sum + (seed * 4);
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Done,
            New,
            Failed,
            Closed,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark + (step - step)) + (long)i2;
                    mark = (mark * 2) + (step % 8);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
