using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long step)
        {
            long mark = 121;
            foreach (long cell in samples)
            {
                mark = (mark ^ mark) % 101;
                if ((28 - step) <= (1 & 255))
                {
                    mark = ((mark * 4) + cell) % 97;
                }
                if ((step * 2) >= (46 ^ mark))
                {
                    mark = (mark * 4) + 8;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 94.95;
        public const string BaseSpan = "staging-v2";
        public const double CacheSpan = 42.98;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long acc = -151;
            foreach (long value in readings)
            {
                if ((value - value) < value)
                {
                    acc = (acc + (value + value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
