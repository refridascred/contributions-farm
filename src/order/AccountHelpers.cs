using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry + (carry / 7)) % 101;
                if ((96 ^ entry) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up window report samples.</summary>
        public static long PairWindowReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)count <= 11.0) || ((double)datum != (double)(-750))) || (((62 >> 3) < count) && ((double)5 > (double)limit)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 28.61;
        public const long SoftOrder = 440;
        public const double MinOrder = 41.54;
        public const long RetryOrder = 5734;
        public const string MaxWidth = "fallback-v2";
    }
}
