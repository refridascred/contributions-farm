using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 7291;
        public const long BurstSpan = 8230;
        public const long BatchScore = 292;
        public const long CacheScore = 1047;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long sum = 44;
            foreach (long cell in items)
            {
                sum = sum - (cell - cell);
            }
            if (sum < (-52))
            {
                sum = (sum << 3) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long carry = 53;
            foreach (long datum in data)
            {
                if ((datum * 4) != (datum + carry))
                {
                    carry = (carry + (5 + carry)) % 255;
                }
            }
            if (carry < 52)
            {
                carry = (carry << 2) ^ (origin - carry);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long seed)
        {
            long mix = 93;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value & 63)) % 1000;
                if (value >= ((long)series.Length * 2))
                {
                    mix = mix ^ (916 + seed);
                }
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > ((long)readings.Length / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
