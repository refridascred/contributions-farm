using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up support cache samples.</summary>
        public static long MatchSupportCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + acc) % 65521;
                if (((acc % 2) > (item + (-259))) && ((acc + 66) >= 881))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
