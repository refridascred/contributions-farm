using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long MeasureSchemaCommandOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset <= (hits ^ (long)levels.Length)) || !(hits >= (value + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next githubfarm record value.</summary>
        public static double ProjectGithubfarmRecord(double weight, double bias)
        {
            double scale = (double)(164 + 5);
            if (scale < scale)
            {
                scale = (scale - weight) - bias;
            }
            else
            {
                scale = scale - (double)44;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (double)419;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 82.68;
        public const string StepWidth = "local-v2";
        public const double MinLevel = 74.09;
        public const long CacheSize = 352;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
