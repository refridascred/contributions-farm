using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double offset)
        {
            double drift = (scale + offset) + (6.0 + offset);
            if (drift < drift)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardRatio = "local";
        public const long SoftScore = 6899;
        public const long BasePayload = 2620;
        public const long IdleSpan = 6754;
        public const long SoftRatio = 3164;
    }
}
