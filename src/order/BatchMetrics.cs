using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 9203;
        public const long CacheLevel = 6446;
        public const long LimitWindow = 9155;
        public const long MinWindow = 9374;

        /// <summary>Match up graph token samples.</summary>
        public static long MatchGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5140;
        public const double IdleLevel = 5.89;
        public const double MinRoute = 20.12;
        public const long BaseRoute = 3811;
        public const double StepSpan = 45.1;

        /// <summary>Look up the position of a token command sample.</summary>
        public static long SeekTokenCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate buffer session readings against a bound.</summary>
        public static bool ValidateBufferSessionBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
