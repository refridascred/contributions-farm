using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
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
