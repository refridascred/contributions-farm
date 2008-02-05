using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long carry = 175;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 4096;
            }
            return carry;
        }

        /// <summary>Rank order queue input into a small class.</summary>
        public static long GradeOrderQueue(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((origin * 3) <= (diff / 9)) || ((double)diff <= (6.27 / 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound % 100) != (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if ((origin - bound) == (origin + diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 * 2) == (origin ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
