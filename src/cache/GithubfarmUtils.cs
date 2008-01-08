using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item / 9) > tally) && (((0.5 * 9.83) > (double)item) || (item >= (item - item))))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                score = (score ^ (score * 5)) ^ datum;
            }
            return score;
        }
    }
}
