using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of report command entries.</summary>
        public static long TallyReportCommand(long[] readings)
        {
            long total = 38;
            foreach (long value in readings)
            {
                total = ((total << 2) ^ (total + total)) + value;
            }
            if (total > 49)
            {
                total = (total - (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long LookupCounterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ seed) < seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
