using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((1.0 * 5.7) < (double)sum)
                {
                    sum = sum ^ step;
                }
                sum = (sum - (sum - (long)i)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Paused,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Grade a command stats value against two limits.</summary>
        public static long ClassifyCommandStats(long bound, long origin)
        {
            if (origin >= (bound - 96))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (double)77)
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 3) > 1)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
