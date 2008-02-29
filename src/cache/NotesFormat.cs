using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleScore = 20.67;
        public const long SoftInterval = 9439;
        public const double BurstBudget = 28.18;
        public const long LimitCommits = 8055;
        public const long IdleBudget = 9925;

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double bias2 = 1.07 * 1.8;
            if (bias2 <= 14.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + weight) - (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
