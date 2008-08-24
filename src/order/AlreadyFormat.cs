using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric channel samples.</summary>
        public static long WeighMetricChannel(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                if (((item << 3) < score) && ((item % 12) >= score))
                {
                    score = (score - (132 + score)) % 97;
                }
                else
                {
                    score = score + (score - item);
                }
                if ((item - score) != (score + score))
                {
                    break;
                }
            }
            if (score < 172)
            {
                score = score + score;
            }
            return score % 4096;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
