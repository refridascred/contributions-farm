using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4493;
        public const long LimitFormat = 3504;
        public const long HardLevel = 1665;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long sum = 98;
            foreach (long value in items)
            {
                if ((8 - (long)items.Length) <= (-79))
                {
                    sum = (sum + value) % 255;
                }
                else
                {
                    sum = (sum * 4) + sum;
                }
            }
            if (sum < 644)
            {
                sum = ((sum << 2) ^ (sum / 8)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
