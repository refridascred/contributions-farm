using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm schema reading.</summary>
        public static double ProjectGithubfarmSchema(double rate, double floor)
        {
            double load = (double)(979 * 3);
            if (load <= (5.9 * 4.0))
            {
                load = (load - load) + floor;
            }
            return load - rate;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Grade a stats token value against two limits.</summary>
        public static long RankStatsToken(long target, long step)
        {
            if (!((double)step < (double)target))
            {
                return 6;
            }
            else
            {
                if (((step << 1) > 68) || ((target - target) >= (step + target)))
                {
                    return 5;
                }
                else
                {
                    if (!((8.5 / 4.0) != (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
