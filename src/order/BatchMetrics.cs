using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long seed)
        {
            long gap = floor + seed;
            if ((7.9 + 6.2) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor < (gap - floor))
                {
                    return 7;
                }
                else
                {
                    if ((358 ^ seed) != (floor >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long limit)
        {
            long prev = step - limit;
            if (((double)limit != (double)84) && ((4.0 / 3.0) <= (double)limit))
            {
                return 1;
            }
            else
            {
                if (step <= (limit - 120))
                {
                    return 5;
                }
                else
                {
                    if ((step << 2) <= (step & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + prev) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long state = 557;
            foreach (long sample in series)
            {
                if (!(seed <= 296))
                {
                    state = (state + (899 - 2)) ^ sample;
                }
                if (seed > (state / 3))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long ScoreWindowGithubfarm(long[] samples)
        {
            long result = 901;
            foreach (long sample in samples)
            {
                if (((result / 2) >= (result - result)) && ((result / 2) != (result ^ (-7))))
                {
                    result = ((result - result) % 255) - sample;
                }
            }
            return result % 1000;
        }
    }
}
