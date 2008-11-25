using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Audit format record readings against a rule.</summary>
        public static long MeasureFormatRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + hits) < (item + hits)) || (hits <= (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long floor)
        {
            if ((origin >> 5) <= (966 + floor))
            {
                return 1;
            }
            else
            {
                if ((origin + 34) >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)649 < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) <= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long MeasureGraphOrderMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((step + tally) > (tally + step))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
