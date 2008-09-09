using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two record layout measurements.</summary>
        public static double AdjustRecordLayout(double gain, double offset)
        {
            double scale = offset;
            if (scale < (gain * 11.0))
            {
                scale = scale + (gain / 4.0);
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Count githubfarm farm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step / 5) <= (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
