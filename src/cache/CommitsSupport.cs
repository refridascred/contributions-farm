using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long BucketNotesWindow(long target, long bound)
        {
            if ((bound >> 2) != (791 - target))
            {
                return 6;
            }
            else
            {
                if ((bound & 31) > (2 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((691 + 753) >= (bound % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long CompareToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            New,
        }

        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long MeasureToolsLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell * 2) <= (seen * 4)) || (((-17) - cell) <= cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
