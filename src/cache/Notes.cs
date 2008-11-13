using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - limit) <= hits) && ((datum + 2) >= (limit >> 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double scale = bias - (floor + floor);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score + (score % 12)) % 255;
                score = ((score << 3) ^ (score << 2)) % 4096;
                if (((score - score) < score) || ((double)score <= (double)score))
                {
                    score = (score + value) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long WeighFormatGithubfarm(long[] levels)
        {
            long total = -5;
            foreach (long sample in levels)
            {
                total = (total ^ (total << 3)) % 101;
                total = total + (total / 2);
                if ((double)sample != (9.0 + 3.4))
                {
                    total = total + ((long)levels.Length + sample);
                }
            }
            return total;
        }
    }
}
