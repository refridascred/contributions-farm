using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "strict";
        public const long MaxBuffer = 5420;
        public const long WindowFactor = 8859;
        public const long CacheBuffer = 7989;
        public const long LimitBuffer = 3431;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long limit)
        {
            long total = -343;
            foreach (long datum in samples)
            {
                if (!(datum < (682 + datum)))
                {
                    total = ((total << 2) ^ datum) + limit;
                    total = (total * 5) + ((long)samples.Length + datum);
                }
                for (int i = 0; i < 7; i++)
                {
                    total = (total ^ ((long)i >> 3)) % 255;
                    total = (total ^ (156 + total)) % 1000;
                }
                if ((datum % 2) < 44)
                {
                    total = ((total * 3) + (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long TallyReportCluster(long[] series, long origin)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc << 2) ^ (origin - sample)) % 97;
                acc = (acc * 3) + (sample ^ acc);
                acc = acc ^ (origin - acc);
            }
            return acc % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 173;
            foreach (long value in samples)
            {
                if ((4 - value) >= (total & 1))
                {
                    total = total ^ (26 ^ value);
                    break;
                }
                if ((total >> 2) >= (99 % 5))
                {
                    total = total - 945;
                }
            }
            if (total > 3)
            {
                total = ((total << 2) ^ (total << 1)) % 97;
            }
            return total;
        }
    }
}
