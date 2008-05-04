using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings, long seed)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (value < (seed - value))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark + (mark - mark)) % 255;
                    mark = (mark * 2) + ((long)i % 10);
                }
                if ((double)seed >= (9.7 + 8.0))
                {
                    mark = (mark + (value * 2)) % 97;
                }
                if ((mark % 60) >= (value / 3))
                {
                    break;
                }
            }
            if (mark < 3)
            {
                mark = mark + (mark ^ 55);
            }
            return mark;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (((sample << 1) < (sum + sample)) && ((sum ^ sum) == (837 + sample)))
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + 98)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long RollGithubfarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor * 3) < acc))
                {
                    acc = (acc - (floor >> 4)) % 101;
                }
                acc = ((acc << 3) ^ acc) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a report record value against two limits.</summary>
        public static long RankReportRecord(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((floor ^ floor) <= step)
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= (floor2 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) > step)
                    {
                        return 1;
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
