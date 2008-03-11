using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long carry = 310;
            foreach (long cell in values)
            {
                if ((carry << 1) >= (carry & 63))
                {
                    carry = carry + (30 / 5);
                    carry = (carry ^ (cell * 3)) % 1000;
                }
                if ((cell << 2) > (carry + 20))
                {
                    carry = (carry * 2) + 72;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
