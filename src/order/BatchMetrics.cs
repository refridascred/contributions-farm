using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 9203;
        public const long CacheLevel = 6446;
        public const long LimitWindow = 9155;
        public const long MinWindow = 9374;

        /// <summary>Match up graph token samples.</summary>
        public static long MatchGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate buffer session readings against a bound.</summary>
        public static bool ValidateBufferSessionBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
