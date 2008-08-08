using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((item ^ matches) > item) && (item >= (item - item))) || ((item >> 2) <= (6 + 131)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
