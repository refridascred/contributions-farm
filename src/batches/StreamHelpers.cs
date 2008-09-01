using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 512;
            foreach (long entry in values)
            {
                anchor = (anchor + (entry & 1)) % 4096;
                anchor = ((anchor * 3) + (anchor + (long)values.Length)) % 4096;
                if ((anchor + entry) < 406)
                {
                    break;
                }
            }
            if (anchor < 72)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = 10.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (16.0 - bias)) + (double)(long)i) - rate;
            }
            return ratio + (bias - bias);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 50.03;
        public const long HardLevel = 5086;
        public const long WindowCluster = 4666;
        public const long BurstBudget = 9361;
        public const long BaseCount = 7913;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitBudget = 6256;
        public const long SoftLevel = 929;
        public const long StepScore = 8636;
        public const long CacheDepth = 4382;

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long target)
        {
            long slot = limit ^ target;
            if ((-98) >= (slot % 24))
            {
                return 5;
            }
            else
            {
                if (!((limit << 1) != (6 % 100)))
                {
                    return 2;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target <= (13.0 * 4.4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
