using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long bound)
        {
            long prev = origin - bound;
            if ((origin & 31) < 670)
            {
                return 7;
            }
            else
            {
                if ((17.0 > (double)prev) && ((double)prev >= 2.1))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) >= (prev % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + seen) >= (seen % 64))
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
