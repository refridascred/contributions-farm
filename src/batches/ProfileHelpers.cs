using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = (offset - offset) - (offset + bias);
            if (load > (offset + bias))
            {
                load = load - offset;
            }
            else
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load * 1.9)) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Project the next schema queue value.</summary>
        public static double AdjustSchemaQueue(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (4.2 + ratio)) + (double)(long)i) + bias;
            }
            return ratio + (double)86;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a already metrics reading by value.</summary>
        public static long SeekAlreadyMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (307 < hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
