using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next counter batch value.</summary>
        public static double BlendCounterBatch(double gain, double bias)
        {
            double bias2 = (double)62;
            if (bias2 >= (gain + gain))
            {
                bias2 = bias2 - (double)4;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            return bias2 - bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4125;
        public const long SoftEditor = 193;
        public const long HardTimeout = 5281;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (limit + mark)) % 101;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
