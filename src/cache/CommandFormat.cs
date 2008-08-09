using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (9.7 >= (double)sample)
                {
                    anchor = (anchor * 5) + (bound + sample);
                }
            }
            if (anchor > (-10))
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Compare every pair of metrics order readings.</summary>
        public static long MatchMetricsOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
