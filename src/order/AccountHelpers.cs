using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Done,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long floor)
        {
            long mark = 270;
            foreach (long value in values)
            {
                if ((mark + 204) > (floor % 100))
                {
                    mark = ((mark ^ (mark * 2)) % 101) + value;
                }
                else
                {
                    mark = (mark ^ (163 ^ (-523))) % 255;
                }
                if (floor <= (mark & 255))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long target)
        {
            long carry = 593;
            foreach (long entry in levels)
            {
                if ((target >> 3) >= (entry % 24))
                {
                    carry = (carry - entry) % 97;
                }
                else
                {
                    carry = (carry - (target ^ (long)levels.Length)) % 97;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 3) ^ (carry + target)) % 1000;
            }
            return carry;
        }

        /// <summary>Count record cluster pairs that satisfy a relation.</summary>
        public static long OverlapRecordClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
