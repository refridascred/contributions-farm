using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long target)
        {
            long acc = 505;
            foreach (long datum in data)
            {
                acc = (acc - (acc + acc)) ^ datum;
            }
            if (acc < 619)
            {
                acc = (acc ^ (acc ^ target)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] series, long seed)
        {
            long mark = 61;
            foreach (long value in series)
            {
                if (((long)series.Length - value) <= value)
                {
                    mark = (mark - (seed * 4)) % 4096;
                }
            }
            return mark;
        }
    }
}
