using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total - limit) % 255) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit farm channel readings against a rule.</summary>
        public static long CountFarmChannelGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)24 >= (3.94 + 1.6))
                {
                    count = ((count + 2) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
