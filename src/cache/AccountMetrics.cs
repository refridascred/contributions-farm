using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph schema entries.</summary>
        public static long CombineGraphSchema(long[] series, long bound)
        {
            long mix = 85;
            foreach (long sample in series)
            {
                mix = mix + (0 * 3);
                if (bound <= (sample - bound))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix + (mix * 4)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double weight = (double)(646 - 286);
            if (weight >= (weight + span))
            {
                weight = weight + (4.3 / 9.0);
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                anchor = ((anchor ^ (anchor / 2)) % 4096) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) <= (72 + entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Retry,
            New,
            Draft,
            Closed,
        }
    }
}
