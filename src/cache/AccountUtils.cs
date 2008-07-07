using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a record stream figure with a bias.</summary>
        public static double ScaleRecordStream(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) + bias2;
            return (ratio - ratio) + bias;
        }
    }
}
