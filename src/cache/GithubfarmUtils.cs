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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long limit2)
        {
            if (!((limit2 - 319) > (441 >> 5)))
            {
                return 2;
            }
            else
            {
                if ((limit2 - limit2) > limit)
                {
                    return 8;
                }
                else
                {
                    if (limit > (18 % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
