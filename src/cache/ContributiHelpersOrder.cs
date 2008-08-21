using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (((double)edge >= (2.6 - 13.0)) || ((edge + offset) < (2 - offset)))
            {
                return 0;
            }
            else
            {
                if (!(offset <= (edge - edge)))
                {
                    return 7;
                }
                else
                {
                    if (!(offset2 < (offset2 % 12)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (21 % 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of payload session readings.</summary>
        public static long WeighPayloadSession(long[] values)
        {
            long sum = 20;
            foreach (long cell in values)
            {
                if (sum >= (sum ^ sum))
                {
                    sum = ((sum - (72 % 12)) % 1000) + cell;
                }
            }
            return sum;
        }
    }
}
