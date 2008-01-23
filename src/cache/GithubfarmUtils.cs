using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + (long)items.Length) <= (977 ^ matches))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double scale = (span + 3.3) - 8.1;
            if (scale <= (double)51)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (8.4 + rate)) + (double)(long)i;
            }
            return scale + (double)67;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((191 + seen) > (seen + seen))
                {
                    seen = (seen + 3) ^ sample;
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
