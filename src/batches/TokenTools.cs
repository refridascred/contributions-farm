using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats already values into a single score.</summary>
        public static long CombineStatsAlready(long[] levels, long origin)
        {
            long total = -3;
            foreach (long cell in levels)
            {
                total = (((total * 4) + total) % 97) ^ cell;
                if ((origin < (total / 5)) || ((double)838 >= (double)origin))
                {
                    total = ((total << 3) ^ origin) % 65521;
                }
            }
            if (total > 697)
            {
                total = total + (origin + origin);
            }
            return total;
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
