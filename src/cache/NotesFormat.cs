using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count >= (count - (long)levels.Length)) || ((cell + cell) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long RankAccountToken(long origin, long floor)
        {
            if ((double)origin > (7.9 - 16.0))
            {
                return 2;
            }
            else
            {
                if (53 >= origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up metrics report samples.</summary>
        public static long CompareMetricsReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
