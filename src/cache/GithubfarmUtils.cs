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

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double rate2 = span - (rate + rate);
            return rate2 - 18.0;
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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen & 255) < seen)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
