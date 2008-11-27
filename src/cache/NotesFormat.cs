using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long carry = 141;
            foreach (long entry in series)
            {
                if (!((entry & 127) > entry))
                {
                    carry = carry + (entry << 1);
                }
                else
                {
                    carry = carry - (entry - entry);
                }
            }
            return carry;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }

        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long TotalContributiCluster(long[] items, long floor)
        {
            long anchor = -1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry + 0)) + floor;
            }
            return anchor;
        }
    }
}
