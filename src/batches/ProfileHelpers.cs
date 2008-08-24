using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 6898;
        public const double LimitRatio = 9.49;
        public const long WindowEntry = 7435;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items)
        {
            long mark = 41;
            foreach (long value in items)
            {
                if ((long)items.Length == (mark & 1))
                {
                    mark = ((mark - ((long)items.Length * 2)) % 65521) - value;
                }
            }
            if (mark > 280)
            {
                mark = (mark - (mark ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((-8) + value) >= seen) && ((value >= (seen * 5)) || ((double)value == (6.6 / 4.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (delta > floor)
            {
                return 2;
            }
            else
            {
                if ((floor << 3) >= (floor >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.4 / 4.0) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta >= (floor2 + 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
