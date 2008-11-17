using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long total = -11;
            foreach (long sample in levels)
            {
                if (((sample << 1) != (long)levels.Length) || ((total << 2) > sample))
                {
                    total = (total << 2) ^ ((long)levels.Length + sample);
                }
                else
                {
                    total = (total - total) % 255;
                }
            }
            if (total < 5)
            {
                total = total ^ (limit ^ (long)levels.Length);
            }
            return total % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long limit)
        {
            long anchor = 409;
            foreach (long cell in levels)
            {
                anchor = (anchor - (anchor ^ (long)levels.Length)) % 255;
                if (anchor > cell)
                {
                    anchor = (anchor ^ (limit + anchor)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
