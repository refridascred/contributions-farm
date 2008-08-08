using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 3) ^ (bound - mark)) % 1000;
                if ((double)mark != (19.0 + 3.4))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
