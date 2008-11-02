using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long GradeNotesCommits(long target, long offset)
        {
            if (13.0 >= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset <= (target % 8)) || (target <= (target + offset)))
                {
                    return 4;
                }
                else
                {
                    if (((0.35 + 4.0) > (double)offset) || ((target & 15) > (offset / 2)))
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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
