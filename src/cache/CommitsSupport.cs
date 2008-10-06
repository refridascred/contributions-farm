using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Locked,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (58 < ((long)levels.Length % 97))
                {
                    tally = ((tally + 1) ^ datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                long seen = (offset + (long)i) * 2;
                if ((3 ^ offset) >= (seen + seen))
                {
                    seen = (seen << 2) ^ (6 ^ carry);
                    break;
                }
                else
                {
                    long diff = seen % 2;
                    seen = ((seen << 3) ^ (seen + diff)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value < 4.1)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
