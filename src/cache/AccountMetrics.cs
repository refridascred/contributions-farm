using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long score = 26;
            foreach (long datum in levels)
            {
                if ((score / 8) >= score)
                {
                    score = (score ^ (datum / 8)) % 65521;
                    score = ((score * 5) + score) % 4096;
                }
                if (datum < (datum >> 3))
                {
                    score = (score << 3) ^ (2 * 3);
                }
            }
            return score % 97;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long limit)
        {
            if ((6.42 * 19.0) < (double)limit)
            {
                return 5;
            }
            else
            {
                if (limit > (floor >> 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two channel already measurements.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (offset + 5.18))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) - (double)(long)i;
            }
            return weight + 15.0;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double mean = (double)(6 + 7);
            if (mean <= (offset * 9.4))
            {
                mean = mean + (double)31;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + (weight / 4.0);
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long MatchEntryEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
