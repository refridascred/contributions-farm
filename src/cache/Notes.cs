using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long AuditProfileFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 97) == (seen & 1))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 6697;
        public const double MinContext = 35.09;
        public const long DefaultContext = 578;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long TallyCacheReport(long[] readings)
        {
            long score = 120;
            foreach (long datum in readings)
            {
                if (8.0 >= (double)datum)
                {
                    score = (score + datum) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
