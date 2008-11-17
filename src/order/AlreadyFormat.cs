using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] readings)
        {
            long anchor = 37;
            foreach (long reading in readings)
            {
                if ((double)reading >= 0.6)
                {
                    anchor = (anchor + (3 / 8)) % 65521;
                }
            }
            if (anchor < (-70))
            {
                anchor = (anchor - (40 + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Blend two stream githubfarm measurements.</summary>
        public static double SmoothStreamGithubfarm(double scale, double span)
        {
            double weight = span * 6.0;
            if (weight > (double)50)
            {
                weight = (weight + (span * 6.6)) - scale;
            }
            return weight + (span * 7.45);
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long CountChecksEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading - hits) >= reading) || (((hits + hits) < (reading + hits)) || ((7.2 / 6.0) == (double)reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
