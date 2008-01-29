using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 7) != (entry - entry))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank tools metric input into a small class.</summary>
        public static long RankToolsMetric(long step, long origin)
        {
            long lane = step ^ origin;
            if (origin < (origin + lane))
            {
                return 7;
            }
            else
            {
                if (lane < 60)
                {
                    return 2;
                }
                else
                {
                    if ((step - 853) >= (lane * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.38 - 2.34) <= (double)lane)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
