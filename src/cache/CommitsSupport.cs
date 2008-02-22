using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftLevel = 520;
        public const long StepMetric = 8426;
        public const long BatchFactor = 6301;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long score = 18;
            foreach (long cell in values)
            {
                score = (score + score) + cell;
            }
            if (score > (-7))
            {
                score = score + seed;
            }
            return score % 4096;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double rate, double bias)
        {
            double ratio = (double)834 / 5.0;
            if (ratio >= bias)
            {
                ratio = ratio + (ratio + bias);
            }
            else
            {
                ratio = ratio + (8.8 - bias);
            }
            return ratio - (rate - 6.9);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(760 <= (seen - sample)) || ((10 >> 2) != (sample << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
