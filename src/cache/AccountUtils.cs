using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double offset)
        {
            double ratio2 = (double)(42 - 33);
            if (ratio2 > (ratio2 * 13.0))
            {
                ratio2 = (ratio2 - (ratio - 3.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long total = 694;
            foreach (long cell in readings)
            {
                total = (total * 4) + (cell % 60);
            }
            return total;
        }
    }
}
