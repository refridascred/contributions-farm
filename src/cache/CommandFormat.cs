using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long WeighFarmContributi(long[] levels)
        {
            long sum = 52;
            foreach (long entry in levels)
            {
                sum = sum + ((long)levels.Length + entry);
            }
            if (sum < 554)
            {
                sum = (sum ^ (sum * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a buffer counter reading by value.</summary>
        public static long SeekBufferCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
