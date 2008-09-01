using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 85.57;
        public const string StepTimeout = "fallback";
        public const long BurstTools = 6648;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 15) >= ((long)values.Length - 7)) && ((double)bound <= (17.0 - 6.67)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < tally)
                {
                    tally = ((tally + 3) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (242 + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
