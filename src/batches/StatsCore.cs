using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long seed)
        {
            long prev = target ^ seed;
            if (!((10 % 97) <= (11 + prev)))
            {
                return 8;
            }
            else
            {
                if ((prev * 5) != (target + 930))
                {
                    return 3;
                }
                else
                {
                    if (((target % 10) > (-90)) || (target >= (target << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.3 - 6.7) <= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 9025;
        public const double RetryWidth = 53.09;
        public const long StepSpan = 7973;
        public const double DefaultAlready = 62.2;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = ((state ^ (state << 2)) % 1000) ^ sample;
            }
            return state;
        }
    }
}
