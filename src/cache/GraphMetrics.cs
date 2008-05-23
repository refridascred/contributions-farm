using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long bound)
        {
            if (((bound * 4) > (-6)) && ((443 & 255) >= (step + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (5.0 + 13.0))
                {
                    return 6;
                }
                else
                {
                    if (((176 - bound) > (step + bound)) || (17.0 > (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (step * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long target)
        {
            long state = 67;
            foreach (long reading in values)
            {
                if ((697 % 2) >= target)
                {
                    state = (state + (target / 7)) - reading;
                }
            }
            if (state > 57)
            {
                state = (state * 2) + (state + 894);
            }
            return state % 65521;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 2639;
        public const long RetryBudget = 2635;
        public const long CacheReport = 745;
    }
}
