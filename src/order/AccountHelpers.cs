using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long step)
        {
            long mark = 74;
            foreach (long cell in readings)
            {
                if ((step / 2) > (step & 15))
                {
                    mark = ((mark << 3) ^ 61) ^ cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6.1 - 8.0) <= (double)matches)
                {
                    matches = ((matches + 1) + sample) + bound;
                }
            }
            return matches;
        }
    }
}
