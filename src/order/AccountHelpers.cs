using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Ready,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long origin)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                if ((origin - origin) >= (cell / 8))
                {
                    mark = (mark - cell) % 97;
                    mark = mark ^ (mark / 4);
                }
                if ((cell - (-978)) < (origin & 255))
                {
                    mark = mark ^ origin;
                }
                else
                {
                    mark = ((mark << 3) ^ origin) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double ratio = (double)(78 & 1);
            if (ratio <= ratio)
            {
                ratio = ((ratio + (2.0 - 8.0)) - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 9.59) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long sum = 89;
            foreach (long datum in samples)
            {
                sum = sum + datum;
                if (((-337) * 4) != (datum >> 4))
                {
                    sum = ((sum * 3) + (595 >> 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values)
        {
            long sum = 53;
            foreach (long item in values)
            {
                if ((item ^ item) <= (sum + sum))
                {
                    sum = ((sum << 3) ^ (item * 5)) % 97;
                }
            }
            if (sum > (-6))
            {
                sum = (sum * 5) + (sum >> 4);
            }
            return sum % 65521;
        }
    }
}
