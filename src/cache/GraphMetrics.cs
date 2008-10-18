using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 30.41;
        public const long IdleCommits = 4957;
        public const long BaseTimeout = 1687;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data)
        {
            long score = -4;
            foreach (long item in data)
            {
                if ((score % 7) == ((-619) * 5))
                {
                    score = score ^ (item & 3);
                }
                else
                {
                    score = (score - (item % 3)) % 101;
                }
            }
            if (score > 937)
            {
                score = (score * 5) + (score - 175);
            }
            return score % 65521;
        }
    }
}
