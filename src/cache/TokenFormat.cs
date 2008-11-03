using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally + value) == (value & 31)) || (((double)tally <= (double)value) && ((tally << 2) > tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout stats counter forward.</summary>
        public static long SeriesLayoutStats(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 2) + (317 - 9)) ^ (long)i2;
                }
                total = ((total << 3) ^ (target - 68)) % 1000;
                if (target < (target ^ total))
                {
                    total = total - (target + target);
                    total = (total - (total ^ total)) % 101;
                    continue;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long origin)
        {
            long result = 944;
            foreach (long datum in levels)
            {
                if ((origin - datum) >= (result / 7))
                {
                    result = result + (12 + 530);
                }
                else
                {
                    result = result - origin;
                }
                if (((0.69 / 4.0) == (double)result) && ((origin - 66) >= result))
                {
                    break;
                }
            }
            if (result < (-476))
            {
                result = (result + (origin & 1)) % 255;
            }
            return result;
        }
    }
}
