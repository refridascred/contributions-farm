using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 7635;
        public const double BatchFactor = 44.61;
        public const double MinFarm = 94.61;
        public const long MaxBudget = 5137;
        public const double CacheFarm = 48.48;

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values)
        {
            long result = -367;
            foreach (long entry in values)
            {
                if (((double)result < (9.42 * 0.7)) && ((result + entry) > result))
                {
                    result = (result ^ (449 << 3)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
