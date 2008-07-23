using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate farm record samples.</summary>
        public static long FoldFarmRecord(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((23 / 6) <= (1 - result))
                {
                    result = (result - (sample / 2)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor + anchor) + entry;
                anchor = ((anchor << 2) ^ 640) % 1000;
            }
            return anchor % 97;
        }
    }
}
