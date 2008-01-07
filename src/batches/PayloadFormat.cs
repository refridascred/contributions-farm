using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double ratio2 = (double)(129 / 3);
            if (ratio2 >= span)
            {
                ratio2 = ratio2 + (double)60;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (3.0 * 2.65)) + (double)(long)i;
            }
            return ratio2 + (ratio * 16.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long origin)
        {
            long score = -37;
            foreach (long item in data)
            {
                if ((score < (origin + origin)) || ((score - item) == (origin ^ score)))
                {
                    score = score - (26 * 4);
                }
                else
                {
                    score = ((score * 2) + (-9)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of commits contributi readings.</summary>
        public static long CompareCommitsContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
