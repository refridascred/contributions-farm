using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitBudget = 86.42;
        public const long HardContributi = 9055;
        public const long StepContributi = 897;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window filter readings.</summary>
        public static long WeighWindowFilter(long[] levels, long limit)
        {
            long mix = -81;
            foreach (long sample in levels)
            {
                mix = (((mix - (mix ^ 4)) % 101) + sample) - limit;
            }
            if (mix > 729)
            {
                mix = mix ^ 728;
            }
            return mix;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long step, long origin)
        {
            long bound = step + origin;
            if ((double)origin > (19.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (!(bound > (bound + origin)))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (bound & 63)) && ((40 + 2) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.2 < (double)origin) || (step >= (bound & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
