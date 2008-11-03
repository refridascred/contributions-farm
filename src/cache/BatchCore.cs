using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6031;
        public const long BaseSize = 8365;
        public const long MaxEditor = 9038;

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double ratio, double span)
        {
            double rate = span;
            if (rate > rate)
            {
                rate = (rate - (5.2 / 5.0)) - ratio;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }
    }
}
