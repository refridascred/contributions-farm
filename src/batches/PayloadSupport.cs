using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Count the route githubfarm entries that pass the check.</summary>
        public static long CountRouteGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.3 >= (double)entry) || ((entry - entry) < (count / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
