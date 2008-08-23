using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report schema samples.</summary>
        public static long CombineReportSchema(long[] levels)
        {
            long score = 927;
            foreach (long reading in levels)
            {
                score = (((score << 3) ^ (score >> 1)) % 4096) - reading;
                score = score + score;
                score = score ^ 148;
            }
            return score % 4096;
        }

        /// <summary>Count cluster commits pairs that satisfy a relation.</summary>
        public static long OverlapClusterCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long seed)
        {
            if ((7.0 - 9.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((9 - seed) < (seed << 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
        }
    }
}
