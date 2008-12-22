using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + carry) % 101) - (long)i;
                }
                carry = (carry - (item + (long)levels.Length)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long offset)
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

        /// <summary>Digest a series of support format entries.</summary>
        public static long CombineSupportFormat(long[] values)
        {
            long carry = 712;
            foreach (long sample in values)
            {
                if ((carry >> 5) > (sample / 3))
                {
                    carry = ((carry * 3) + (carry + (-85))) % 255;
                }
            }
            if (carry > 75)
            {
                carry = ((carry << 2) ^ (carry % 60)) % 65521;
            }
            return carry % 4096;
        }
    }
}
