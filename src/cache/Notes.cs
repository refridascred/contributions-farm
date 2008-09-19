using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long seed)
        {
            long anchor = 63;
            foreach (long sample in readings)
            {
                if ((sample >> 3) == (sample + anchor))
                {
                    anchor = (anchor * 4) + (sample - anchor);
                    break;
                }
                if (!(57 <= (sample * 2)))
                {
                    anchor = (anchor + (seed + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
            }
            if (anchor < (-9))
            {
                anchor = ((anchor * 2) + (anchor + seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (offset >= (92 % 3))
            {
                return 4;
            }
            else
            {
                if ((double)target == (9.8 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen ^ seen) == (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long origin)
        {
            long score = 24;
            foreach (long datum in readings)
            {
                if ((datum << 2) > (score >> 3))
                {
                    score = (score << 3) ^ (origin - score);
                }
            }
            return score % 4096;
        }
    }
}
