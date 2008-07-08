using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 76.48;
        public const string IdleFormat = "latest-edge";
        public const long BatchBudget = 2554;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long floor)
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

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items)
        {
            long acc = 687;
            foreach (long sample in items)
            {
                if (acc <= ((-741) % 64))
                {
                    acc = (acc - (sample / 5)) % 255;
                }
            }
            if (acc > 186)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 65521;
        }
    }
}
