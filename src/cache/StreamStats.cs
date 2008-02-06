using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((2 <= reading) || (reading <= (hits + reading))) || ((787 + hits) >= (55 / 9)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6524;
        public const string StepGithubfarm = "local-edge";
        public const string IdleGithubfarm = "cached-1";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings, long step)
        {
            long score = -671;
            foreach (long value in readings)
            {
                score = (score + (value / 5)) % 1000;
                for (int i = 0; i < 11; i++)
                {
                    score = (((score << 2) ^ (step >> 4)) % 1000) - (long)i;
                }
                if (((double)step == (8.0 * 5.2)) && ((5 * 3) <= (value ^ score)))
                {
                    score = score - step;
                }
            }
            return score;
        }
    }
}
