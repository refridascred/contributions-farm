using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long MeasureLayoutEditorGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((limit >> 2) > (142 + matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ((ratio2 + ratio) + (double)(long)i) - span;
            }
            return ratio2 + (double)5;
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long DeriveOrderSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum - target) > target)
                {
                    continue;
                }
                if (!!((double)sum >= (17.0 - 0.04)))
                {
                    sum = ((sum << 3) ^ target) % 4096;
                }
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
