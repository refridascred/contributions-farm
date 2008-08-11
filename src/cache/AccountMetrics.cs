using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine queue cache values into a single score.</summary>
        public static long WeighQueueCache(long[] samples, long seed)
        {
            long result = -52;
            foreach (long cell in samples)
            {
                result = (result * 3) + (seed - cell);
                result = (result + (seed / 9)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Count stats commits pairs that satisfy a relation.</summary>
        public static long PairStatsCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 7247;
        public const long MaxChannel = 9770;
        public const double SoftChannel = 79.28;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count == (6.04 / 6.0))
                {
                    count = ((count + 3) + item) - target;
                }
            }
            return count;
        }
    }
}
