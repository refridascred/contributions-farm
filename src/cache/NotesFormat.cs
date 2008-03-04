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

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 7913;
        public const long BaseFactor = 8711;
        public const string DefaultInterval = "primary-1";
        public const long IdleLevel = 1775;
        public const string IdleTimeout = "legacy-edge";

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
