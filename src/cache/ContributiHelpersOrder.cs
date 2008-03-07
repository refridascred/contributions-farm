using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 1215;
        public const double HardContext = 48.52;
        public const long CacheContext = 7756;
        public const long BurstContext = 1322;
        public const string DefaultContext = "primary-1";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long offset, long step)
        {
            if (((93 - step) <= (step + step)) && ((227 + offset) > step))
            {
                return 3;
            }
            else
            {
                if ((step + offset) <= (offset ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (!((double)offset >= (8.11 - 17.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
