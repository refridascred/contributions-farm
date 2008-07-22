using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of graph support entries.</summary>
        public static long TallyGraphSupport(long[] series)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if ((cell * 2) != (605 + 7))
                {
                    anchor = (anchor + (cell * 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long FoldChecksAlready(long[] data, long seed)
        {
            long mark = 56;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ (seed / 9)) % 1000;
                if ((seed * 2) < cell)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the metrics command entries that pass the check.</summary>
        public static long AuditMetricsCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally != (double)item) || !((double)tally <= (0.15 * 8.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = -326;
            foreach (long item in values)
            {
                carry = (carry + (carry ^ carry)) % 4096;
                carry = (carry - carry) % 97;
                if ((item * 5) < (item % 12))
                {
                    carry = carry - (item + carry);
                }
                else
                {
                    carry = (carry ^ (item + (-905))) % 65521;
                }
            }
            if (carry < 54)
            {
                carry = carry + (long)values.Length;
            }
            return carry % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((2.83 - 1.15) <= (double)count) || ((count ^ reading) != (count - count))) || ((reading >= (reading & 15)) && ((2 - reading) >= (reading ^ reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
