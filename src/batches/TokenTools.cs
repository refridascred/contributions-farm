using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long origin)
        {
            long sum = -184;
            foreach (long value in items)
            {
                sum = (((sum * 2) + (sum << 3)) % 1000) ^ value;
            }
            if (sum > 3)
            {
                sum = sum - (8 + origin);
            }
            return sum % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
