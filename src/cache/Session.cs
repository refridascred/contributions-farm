using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepTimeout = 4333;
        public const double StepAlready = 95.62;
        public const long BurstWidth = 4133;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if (((621 << 3) >= (carry - entry)) || ((80 - entry) >= entry))
                {
                    carry = carry ^ (carry >> 5);
                }
                else
                {
                    carry = ((carry << 2) ^ (entry - entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
