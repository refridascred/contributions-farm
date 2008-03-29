using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + item) > (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) > 5)
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long score = 918;
            foreach (long reading in series)
            {
                if (17.0 <= (double)score)
                {
                    score = (score << 3) ^ (136 + reading);
                }
                else
                {
                    score = ((score * 4) + (reading % 8)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
