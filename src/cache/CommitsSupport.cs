using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - datum) <= (5 * 5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches cache pair into a bucket.</summary>
        public static long ClassifyBatchesCache(long limit, long origin)
        {
            long next = limit - origin;
            if (origin > ((-2) + limit))
            {
                return 6;
            }
            else
            {
                if ((double)next == (9.2 + 14.0))
                {
                    return 2;
                }
                else
                {
                    if (4 >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin / 3) != (next ^ origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double weight2 = (1.41 - floor) * 5.56;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (floor - floor)) - weight;
            }
            return weight2 - 1.0;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) != (sample + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
