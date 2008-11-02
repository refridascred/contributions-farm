using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long step)
        {
            if (step < (step - step))
            {
                return 8;
            }
            else
            {
                if ((548 + bound) > 90)
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) > (step ^ 56))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step + step) <= (bound - step)) && (step < (step % 12)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
