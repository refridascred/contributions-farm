using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 400;
            foreach (long cell in values)
            {
                if ((carry - (-5)) > (cell - cell))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ cell) % 255;
                if ((double)carry <= 0.59)
                {
                    carry = (carry ^ (carry & 127)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 9787;
        public const double MaxBatches = 72.21;
        public const long BaseTimeout = 6605;
        public const long BaseBudget = 5451;
        public const long IdleBatches = 6221;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
