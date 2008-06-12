using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long mark = 74;
            foreach (long sample in samples)
            {
                if ((7 / 8) >= sample)
                {
                    mark = (mark - (99 << 3)) % 4096;
                }
            }
            if (mark < 97)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the metric window entries that pass the check.</summary>
        public static long TallyMetricWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4.27 + 8.96) <= (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
