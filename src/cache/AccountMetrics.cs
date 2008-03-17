using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count <= 8.0) || (((long)items.Length * 4) != (count * 5)))
                {
                    count = ((count + 3) - value) - origin;
                }
            }
            return count;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long GradeEditorCommits(long seed, long seed2)
        {
            if ((313 ^ seed) == (seed % 64))
            {
                return 1;
            }
            else
            {
                if (53 < (seed2 & 15))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 3) >= (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) < (419 % 16)) || ((double)seed2 != (6.58 - 3.61)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long step)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum - (sum + step)) % 65521;
                if ((12.0 - 17.0) <= (double)sum)
                {
                    sum = (sum + (sum - value)) % 65521;
                }
                if (!((sum / 9) >= (step - 1)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (7.0 - 8.0)) || ((value - value) <= (value * 2)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a already buffer value against two limits.</summary>
        public static long GradeAlreadyBuffer(long seed, long step)
        {
            if (step > (step + seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (double)82)
                {
                    return 0;
                }
                else
                {
                    if ((seed % 12) > (seed % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + seed) >= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
