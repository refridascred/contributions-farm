using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6.0 * 3.97) <= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double ratio = (double)0 * 3.75;
            if (ratio >= rate)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (16.0 - offset);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) > (count & 31))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
