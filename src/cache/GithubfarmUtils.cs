using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank schema support input into a small class.</summary>
        public static long ClassifySchemaSupport(long origin, long target)
        {
            long diff = origin ^ target;
            if ((((-91) & 255) <= diff) || ((diff % 97) >= (origin & 63)))
            {
                return 5;
            }
            else
            {
                if (!(target <= 43))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (8.97 * 8.71))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate schema report samples.</summary>
        public static long TallySchemaReport(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                if ((value - value) <= score)
                {
                    score = (score + (score ^ score)) % 4096;
                }
                else
                {
                    score = (score - (score & 1)) % 1000;
                }
            }
            if (score > (-759))
            {
                score = score ^ (score + 7);
            }
            return score;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
