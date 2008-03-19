using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long target)
        {
            if (6.0 <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((double)floor != (8.41 + 2.06)) || (target >= floor))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the githubfarm context series from a seed.</summary>
        public static long StepGithubfarmContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)origin < (4.8 + 10.0))
                {
                    acc = acc + origin;
                    acc = (acc << 2) ^ origin;
                }
                else
                {
                    acc = (acc * 3) + (501 << 3);
                }
                if ((origin + acc) >= ((long)i * 4))
                {
                    acc = acc + (acc >> 5);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
