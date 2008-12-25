using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryDepth = 41.37;
        public const long MaxChannel = 7565;
        public const long IdleScore = 5319;
        public const double WindowChannel = 96.19;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long anchor = 28;
            foreach (long value in readings)
            {
                if ((anchor + anchor) > value)
                {
                    anchor = (anchor ^ (anchor + value)) % 65521;
                }
                else
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            return anchor;
        }
    }
}
