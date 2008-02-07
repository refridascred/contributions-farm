using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph queue value against two limits.</summary>
        public static long RankGraphQueue(long step, long floor)
        {
            if ((double)step != (double)floor)
            {
                return 3;
            }
            else
            {
                if ((596 < step) || ((step + (-7)) >= (step / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) >= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (611 ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            New,
            Failed,
            Stale,
        }
    }
}
