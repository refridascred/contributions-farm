using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if ((reading & 255) < (score << 3))
                {
                    score = score + (score + score);
                }
                else
                {
                    score = score ^ (reading - reading);
                }
            }
            if (score < 2)
            {
                score = (score - (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((2 + tally) < (sample - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
