using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long bound)
        {
            if ((double)bound == (5.36 + 2.0))
            {
                return 2;
            }
            else
            {
                if (((origin & 255) == (origin - origin)) && ((origin + bound) > (bound % 12)))
                {
                    return 8;
                }
                else
                {
                    if (((origin & 15) == (origin - bound)) || ((double)bound > (3.0 / 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - origin) < (13 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double load = weight / 2.0;
            if (load < span)
            {
                load = load - (span / 4.0);
            }
            else
            {
                load = load - load;
            }
            return load - span;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
