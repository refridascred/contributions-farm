using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if (!(origin <= (step % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)origin > 16.0)
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (step ^ origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Closed,
            Stale,
            Synced,
            Ready,
        }
    }
}
