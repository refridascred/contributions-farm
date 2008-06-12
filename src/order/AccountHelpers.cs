using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long acc = 47;
            foreach (long datum in series)
            {
                acc = ((acc ^ (0 << 2)) % 4096) + datum;
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry >> 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double rate2 = (double)(837 + 35);
            return ((rate2 - (double)3) + rate) + offset;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) > (floor + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache queue measurements.</summary>
        public static double ScaleCacheQueue(double bias, double bias2)
        {
            double gain = 6.8;
            if (gain < bias2)
            {
                gain = gain + (bias / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias + gain)) - (double)(long)i;
            }
            return gain - (bias / 3.0);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
