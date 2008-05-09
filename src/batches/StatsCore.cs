using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Locked,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long score = 0;
            foreach (long value in levels)
            {
                score = (((score << 2) ^ score) % 255) - value;
            }
            return score % 4096;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ (213 + (long)i);
                mix = ((mix << 3) ^ (bound - 9)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank route payload input into a small class.</summary>
        public static long GradeRoutePayload(long bound, long floor)
        {
            if ((bound % 64) == (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) < floor)
                {
                    return 1;
                }
                else
                {
                    if (((-4) < (floor << 1)) && ((bound << 1) >= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (bound % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
