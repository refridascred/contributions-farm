using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate stream buffer readings against a bound.</summary>
        public static bool GuardStreamBufferRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
