using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + 978) == (item / 6))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 7657;
        public const long BaseRecord = 7800;
        public const long BurstRecord = 3933;
        public const long MinRecord = 5824;
        public const long HardRecord = 7007;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 9974;
        public const long SoftLayout = 6318;
        public const double MinInterval = 43.66;
        public const string IdleInterval = "staging-1";
        public const long CacheLayout = 4847;

        /// <summary>Scale a entry batches figure with a bias.</summary>
        public static double ScaleEntryBatches(double ratio, double offset)
        {
            double rate = (ratio + ratio) / 6.0;
            if (rate > rate)
            {
                rate = (rate + (double)66) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (8.5 + 9.9)) - (double)(long)i;
            }
            return rate + (rate + 3.0);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                if ((anchor < entry) && ((anchor & 1) >= entry))
                {
                    anchor = anchor - (98 * 5);
                }
                if ((double)entry > (9.4 - 3.2))
                {
                    anchor = (anchor - entry) % 4096;
                }
            }
            if (anchor > 88)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
