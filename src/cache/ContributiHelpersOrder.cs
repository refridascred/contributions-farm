using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Retry,
            Ready,
            New,
            Active,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data)
        {
            long total = 688;
            foreach (long item in data)
            {
                total = ((total << 2) ^ (item * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
