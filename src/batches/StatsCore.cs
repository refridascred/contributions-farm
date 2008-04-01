using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first stream buffer entry that matches the target.</summary>
        public static long FindStreamBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long floor)
        {
            if ((step * 2) < 85)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (5.3 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (limit >= (matches + 97))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long carry = 37;
            foreach (long value in items)
            {
                if (value < carry)
                {
                    carry = ((carry << 2) ^ (value + carry)) % 101;
                }
                carry = carry ^ (value << 1);
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
