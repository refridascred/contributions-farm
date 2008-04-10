using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long result = 6;
            foreach (long item in levels)
            {
                result = ((result - (53 / 8)) % 4096) + target;
                result = ((result << 3) ^ (item * 5)) % 255;
            }
            if (result > 5)
            {
                result = (result + ((-28) & 3)) % 97;
            }
            return result;
        }

        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long CountAlreadyClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches <= (datum % 97)) || (62 > (datum % 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit / 9)) % 1000;
                if (!((acc ^ limit) <= acc))
                {
                    acc = (acc * 5) + (987 & 7);
                    continue;
                }
                else
                {
                    acc = ((acc << 3) ^ (228 >> 1)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
