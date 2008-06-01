using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a report checks reading by value.</summary>
        public static long LocateReportChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((17.0 * 8.6) > (double)item) && (((798 & 7) <= matches) || ((item ^ matches) <= (717 + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
