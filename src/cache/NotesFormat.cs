using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long step2)
        {
            long span = step ^ step2;
            if (((step2 + step) <= (1 ^ 572)) || ((step << 3) != (span & 127)))
            {
                return 2;
            }
            else
            {
                if (((double)step == (0.2 - 20.0)) && (step > (step2 * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 + step) <= (span * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) > (771 + (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
