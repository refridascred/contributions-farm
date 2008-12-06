using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine format commits values into a single score.</summary>
        public static long DigestFormatCommits(long[] series, long target)
        {
            long acc = 232;
            foreach (long cell in series)
            {
                acc = acc ^ (945 & 255);
                if (((target - acc) < acc) && ((double)target >= (double)acc))
                {
                    acc = (acc << 3) ^ (cell - acc);
                }
                if (!((cell & 31) < (cell << 3)))
                {
                    break;
                }
            }
            if (acc < (-70))
            {
                acc = ((acc * 5) + (target << 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((target - target) != (entry % 12)) || ((target + hits) == (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
