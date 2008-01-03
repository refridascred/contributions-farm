using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long ClassifyEntryMetrics(long bound, long seed)
        {
            if (bound <= (bound + seed))
            {
                return 6;
            }
            else
            {
                if (!((bound & 1) <= (28 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) != (95 ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((824 ^ bound) > (bound >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
