using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long target)
        {
            if ((target * 5) < target)
            {
                return 7;
            }
            else
            {
                if (((floor % 5) >= (floor + floor)) && ((double)target < (3.0 + 0.27)))
                {
                    return 8;
                }
                else
                {
                    if (((target + target) >= (target - target)) && ((target % 24) >= (floor ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
