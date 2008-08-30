using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 609;
            foreach (long entry in values)
            {
                result = (result ^ ((-239) ^ entry)) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 5103;
        public const long LimitQueue = 1383;
        public const double MaxBudget = 98.39;
    }
}
