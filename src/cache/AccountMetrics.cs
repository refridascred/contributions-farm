using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples)
        {
            long score = -62;
            foreach (long entry in samples)
            {
                score = ((score * 5) + (entry ^ 16)) % 101;
            }
            return score;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long target)
        {
            if ((limit - target) < ((-3) + 95))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (18.0 * 12.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batches report value from a seed.</summary>
        public static long RollBatchesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two farm report measurements.</summary>
        public static double AdjustFarmReport(double rate, double span)
        {
            double bias = (rate + 1.06) + span;
            if (bias < (double)305)
            {
                bias = bias - (bias - span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate * 5.66)) - (double)(long)i;
            }
            return bias + (rate / 5.0);
        }
    }
}
