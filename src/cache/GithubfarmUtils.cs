using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - matches) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 76;
            foreach (long entry in items)
            {
                if ((entry % 16) > (total % 60))
                {
                    total = (total ^ total) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 80;
            foreach (long entry in readings)
            {
                anchor = (anchor + (anchor + anchor)) ^ entry;
                if ((0.8 * 14.0) <= (double)anchor)
                {
                    anchor = (anchor << 2) ^ (1 % 64);
                }
            }
            return anchor;
        }
    }
}
