using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 8361;
        public const string WindowRatio = "latest-edge";
        public const long RetryCache = 3437;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((7.65 - 6.0) >= (double)reading)
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7057;
        public const double MaxSupport = 4.0;
        public const double BaseBudget = 26.18;
        public const long MinSupport = 8246;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
