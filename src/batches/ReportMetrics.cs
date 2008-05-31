using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next filter window value from a seed.</summary>
        public static long RollFilterWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i <= (carry << 1)))
                {
                    carry = carry + (81 + floor);
                    carry = (carry * 2) + (floor - carry);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long ScoreEditorMetric(long[] series, long origin)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = total - (total & 31);
                if (((total + origin) != ((long)series.Length ^ total)) && (((long)series.Length / 8) < value))
                {
                    total = (total - (origin % 24)) % 255;
                }
            }
            return total;
        }
    }
}
