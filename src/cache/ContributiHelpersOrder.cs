using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long total = 836;
            foreach (long value in values)
            {
                if ((7.0 / 8.0) >= (double)value)
                {
                    continue;
                }
                if (!((value * 3) <= (total - value)))
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Ready,
            Stale,
            Idle,
            Draft,
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
