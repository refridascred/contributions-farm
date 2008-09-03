using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels)
        {
            long mark = 848;
            foreach (long reading in levels)
            {
                if (!((reading + mark) <= (mark - mark)))
                {
                    mark = ((mark << 2) ^ (reading + 975)) % 255;
                }
            }
            if (mark > 12)
            {
                mark = ((mark << 2) ^ (mark << 1)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
