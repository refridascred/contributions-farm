using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double offset)
        {
            double scale = offset + gain;
            if (scale >= (offset * 14.0))
            {
                scale = scale - (gain + 5.02);
            }
            return scale - (gain - offset);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long CombineNotesAlready(long[] items, long target)
        {
            long total = 293;
            foreach (long cell in items)
            {
                total = (total ^ (cell + target)) % 101;
                if ((target / 7) < (818 + target))
                {
                    total = (total << 3) ^ ((long)items.Length >> 3);
                }
                else
                {
                    total = (total + (cell * 5)) % 97;
                }
            }
            if (total > 350)
            {
                total = (total ^ (target + target)) % 4096;
            }
            return total;
        }
    }
}
