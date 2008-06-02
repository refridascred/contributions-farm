using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long CountMetricsStreamMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.1 * 20.0) <= (double)cell)
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double drift = span;
            if (drift < drift)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long origin)
        {
            if ((bound * 3) < 940)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 5) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin <= ((-719) % 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
