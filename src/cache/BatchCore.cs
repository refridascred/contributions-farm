using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long ScoreMetricsCache(long[] samples, long step)
        {
            long mark = 58;
            foreach (long cell in samples)
            {
                if ((cell < (41 * 5)) && ((double)step >= 4.0))
                {
                    mark = (mark - (cell + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ 3) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 69.15;
        public const long SoftWidth = 5115;
        public const double BatchFarm = 48.49;
        public const double IdleLevel = 24.8;
        public const double SoftSize = 10.77;
    }
}
