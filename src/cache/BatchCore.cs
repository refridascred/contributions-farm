using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings, long floor)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if (((floor * 3) != (6 - cell)) || ((2.0 - 5.8) <= (double)floor))
                {
                    result = ((result * 3) + (long)readings.Length) % 1000;
                }
            }
            if (result < 297)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result % 4096;
        }
    }
}
