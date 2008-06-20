using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a contributi githubfarm pair into a bucket.</summary>
        public static long GradeContributiGithubfarm(long target, long origin)
        {
            long slot = target + origin;
            if ((origin + origin) <= (-551))
            {
                return 7;
            }
            else
            {
                if ((double)origin > (double)slot)
                {
                    return 5;
                }
                else
                {
                    if (7.35 > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.9 + 11.0) != (double)slot) && ((double)origin > (double)222))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long limit)
        {
            if ((92 < target) && ((1.3 - 3.0) > (double)target))
            {
                return 1;
            }
            else
            {
                if (!((target + target) != (limit / 2)))
                {
                    return 2;
                }
                else
                {
                    if (target < (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + target) > (limit - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
