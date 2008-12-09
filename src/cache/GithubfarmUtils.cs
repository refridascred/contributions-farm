using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if ((bound - 6) < (bound2 - bound2))
            {
                return 7;
            }
            else
            {
                if (bound2 > span)
                {
                    return 3;
                }
                else
                {
                    if (((1.7 / 2.0) == (double)bound) || ((bound2 * 3) != (span + span)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 / 6) <= bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
