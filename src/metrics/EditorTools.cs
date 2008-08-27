using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > 3.7)
            {
                rate2 = rate2 + (rate / 2.0);
            }
            return rate2 + (double)(-970);
        }

        /// <summary>Count the account already entries that pass the check.</summary>
        public static long TallyAccountAlreadyHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((bound >= (86 >> 2)) || ((bound < (tally >> 3)) || ((tally % 60) == (553 << 3))))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (!((149 ^ entry) == (anchor + entry)))
                {
                    anchor = (anchor * 2) + 111;
                }
                anchor = (anchor + ((long)items.Length >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches % 97) > 827) || ((284 + value) >= (matches - 631)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
