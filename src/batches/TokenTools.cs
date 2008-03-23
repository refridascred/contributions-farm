using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long CountSupportEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!((tally - sample) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (double)count)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Idle,
            Draft,
            Failed,
            Locked,
        }
    }
}
