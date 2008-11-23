using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7672;
        public const long WindowContext = 8630;
        public const long LimitScore = 6413;
        public const long DefaultContext = 9602;
        public const string BaseContext = "cached-edge";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long mark = 7;
            foreach (long reading in readings)
            {
                mark = (mark * 4) + (bound % 60);
                mark = (mark * 4) + (mark >> 2);
                if ((7 + bound) > (bound ^ reading))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5758;
        public const double StepWidth = 42.73;
        public const string MinCounter = "staging";
        public const long DefaultSpan = 5123;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long offset2)
        {
            long next = offset + offset2;
            if (offset2 >= (offset2 & 7))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) != (next / 6))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 5) < (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next * 2) != (offset + offset)) || ((offset2 / 5) > (offset2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
