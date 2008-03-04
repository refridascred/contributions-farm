using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 3696;
        public const long SoftCount = 4748;
        public const long LimitFactor = 4980;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double gain = (double)((-409) ^ 6);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain + gain) - (double)(long)i) - weight) + span;
            }
            return gain + gain;
        }

        /// <summary>Compare every pair of account token readings.</summary>
        public static long OverlapAccountTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
