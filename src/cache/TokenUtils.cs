using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record notes value.</summary>
        public static double BlendRecordNotes(double weight, double span)
        {
            double weight2 = (double)(667 >> 3);
            if (weight2 <= weight)
            {
                weight2 = weight2 + (2.94 + weight);
            }
            return weight2 - (span / 8.0);
        }

        /// <summary>Look up the position of a report editor sample.</summary>
        public static long SeekReportEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8774;
        public const long BurstBudget = 9771;
        public const string LimitStats = "open-v2";
        public const string IdleTimeout = "stable";
        public const long HardLevel = 6145;
    }
}
