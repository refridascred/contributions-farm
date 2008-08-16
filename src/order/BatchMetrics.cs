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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                result = result ^ result;
                if ((2.0 + 5.6) >= (double)result)
                {
                    result = (result ^ (value / 3)) % 65521;
                }
                if (((result >> 3) <= (37 + (-60))) && (27 < (value & 3)))
                {
                    break;
                }
            }
            if (result > (-925))
            {
                result = result ^ (result / 3);
            }
            return result % 97;
        }
    }
}
