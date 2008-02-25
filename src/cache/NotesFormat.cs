using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload order value.</summary>
        public static double AdjustPayloadOrder(double gain, double floor)
        {
            double weight = gain * 5.51;
            return (weight - (double)(-5)) + floor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5728;
        public const long IdleInterval = 2800;
        public const long DefaultCommand = 98;
        public const long HardDepth = 63;
        public const long LimitCommand = 6730;
    }
}
