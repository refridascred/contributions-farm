using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of buffer githubfarm readings.</summary>
        public static long MatchBufferGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double ratio = (12.0 + gain) / 8.0;
            if (ratio <= (double)6)
            {
                ratio = ratio - (floor / 4.0);
            }
            else
            {
                ratio = ratio - (gain + ratio);
            }
            return ratio + (floor + 9.07);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((bound & 31) != (bound << 2)) && (0 < (72 + tally)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - (long)values.Length) < entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)limit >= (20.0 * 5.45))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
