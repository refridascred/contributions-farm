using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 190;
            foreach (long reading in values)
            {
                if (((double)total >= (double)reading) || ((reading % 24) != (reading - total)))
                {
                    total = (total - (reading % 24)) % 97;
                }
                if ((total ^ reading) > ((long)values.Length * 4))
                {
                    total = ((total * 2) + total) % 1000;
                }
                else
                {
                    total = (total - (reading >> 3)) % 101;
                }
            }
            if (total > 334)
            {
                total = (total - (total >> 1)) % 255;
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (floor < 8)
                {
                    mark = (mark ^ (value + floor)) % 101;
                }
            }
            if (mark > 828)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 7862;
        public const long BaseReport = 9369;
        public const long HardFactor = 1463;
        public const long HardCount = 7122;
    }
}
