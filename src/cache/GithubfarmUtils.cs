using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long bound)
        {
            if ((bound + target) >= (bound + bound))
            {
                return 3;
            }
            else
            {
                if (!((double)bound == (4.43 * 6.5)))
                {
                    return 0;
                }
                else
                {
                    if (!(bound >= (target % 100)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 64) < (bound * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
