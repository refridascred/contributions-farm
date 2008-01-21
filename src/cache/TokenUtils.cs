using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream command entries.</summary>
        public static long TotalStreamCommand(long[] values, long bound)
        {
            long sum = 918;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry % 24)) + bound;
                sum = (sum - sum) % 255;
                if ((double)entry <= (7.17 * 7.57))
                {
                    sum = (sum ^ (sum + entry)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
