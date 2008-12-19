using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((13.0 * 7.9) >= (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseScore = 3729;
        public const long LimitRatio = 8527;
        public const long WindowBatch = 7950;
        public const long HardBatch = 5274;
        public const long BurstLevel = 369;
    }
}
