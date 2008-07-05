using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 4417;
        public const long RetryAlready = 8788;
        public const long BaseFactor = 8620;
        public const long MinAlready = 306;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] data)
        {
            long anchor = -964;
            foreach (long sample in data)
            {
                if ((anchor & 1) != (sample >> 1))
                {
                    anchor = anchor ^ (anchor ^ sample);
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor + 5) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long limit)
        {
            long total = -418;
            foreach (long reading in samples)
            {
                if ((5.5 + 6.0) >= (double)limit)
                {
                    total = (total ^ reading) % 65521;
                    total = (total + (1 >> 3)) % 97;
                }
                else
                {
                    total = (total + reading) % 255;
                    total = ((total << 2) ^ reading) % 1000;
                }
                if ((limit + limit) <= total)
                {
                    total = (total + (reading ^ reading)) % 4096;
                }
                else
                {
                    total = total ^ 42;
                }
                if (((reading + total) != (reading - total)) && ((double)reading > (14.0 / 5.0)))
                {
                    total = (total - (total ^ limit)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
