using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry format value from a seed.</summary>
        public static long RollEntryFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ ((long)i / 7)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if (datum <= 13)
                {
                    mix = ((mix << 3) ^ (mix + 73)) % 97;
                }
            }
            if (mix > 88)
            {
                mix = mix - (mix - mix);
            }
            return mix;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
