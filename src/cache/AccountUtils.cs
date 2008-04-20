using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 165;
            foreach (long datum in items)
            {
                if (((datum >> 3) < total) || ((double)datum > 11.0))
                {
                    continue;
                }
                else
                {
                    total = ((total * 5) + 5) % 1000;
                }
                total = total - (total + total);
            }
            if (total > 7)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long AuditEditorSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)matches != (5.36 + 14.0)) && ((matches + entry) > entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
