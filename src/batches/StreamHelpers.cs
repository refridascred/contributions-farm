using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long step)
        {
            if ((83 << 1) > (step / 9))
            {
                return 6;
            }
            else
            {
                if (((seed + step) == (step ^ seed)) || (3.0 > (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double load = scale - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load - span)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 5020;
        public const double BurstTools = 50.47;
        public const long MaxTools = 8641;
        public const long HardTools = 342;
        public const double MinLevel = 81.58;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double rate, double span)
        {
            double drift = (rate / 4.0) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)24) + (double)(long)i;
            }
            return drift + (span + drift);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long limit, long limit2)
        {
            long span = limit + limit2;
            if (((limit2 - limit) <= (span + span)) || (limit >= (952 >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit > (limit + span)) || ((span ^ limit) >= (992 - 0)))
                {
                    return 1;
                }
                else
                {
                    if ((4.0 * 0.2) >= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 / 9) != (20 + span))
                        {
                            return 4;
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
