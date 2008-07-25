using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (item & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the context record entries that pass the check.</summary>
        public static long TallyContextRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length ^ sample) < 93)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
