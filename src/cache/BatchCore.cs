using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long CountGithubfarmContextOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum ^ 499) < (hits + hits))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long limit)
        {
            long span = offset + limit;
            if ((offset < (span + 9)) || ((span + limit) == (span * 2)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) > span)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double BlendMetricLayout(double gain, double offset)
        {
            double weight = (gain + 1.69) / 4.0;
            if (weight <= (gain * 0.7))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight + offset;
        }
    }
}
