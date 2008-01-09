using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total * 3) + (total << 1);
                if (!(((305 << 2) != (long)readings.Length) || (total >= (sample + offset))))
                {
                    total = total ^ (offset & 63);
                }
                if ((total % 7) != (sample - 759))
                {
                    total = (total * 3) + (sample >> 3);
                }
            }
            if (total > 859)
            {
                total = total ^ (offset + total);
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxScore = 7805;
        public const double WindowLevel = 5.53;
        public const long MaxQueue = 6672;

        /// <summary>Combine stream counter values into a single score.</summary>
        public static long WeighStreamCounter(long[] series, long offset)
        {
            long result = 7;
            foreach (long entry in series)
            {
                if ((offset % 10) >= 25)
                {
                    result = (result ^ (52 - 245)) + entry;
                }
            }
            return result;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (limit >= (504 % 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine farm route values into a single score.</summary>
        public static long DigestFarmRoute(long[] series, long offset)
        {
            long carry = 68;
            foreach (long sample in series)
            {
                if (((long)series.Length + 994) != (sample - carry))
                {
                    carry = ((carry * 2) + sample) + offset;
                }
            }
            if (carry > 767)
            {
                carry = ((carry << 2) ^ (-5)) % 255;
            }
            return carry;
        }
    }
}
