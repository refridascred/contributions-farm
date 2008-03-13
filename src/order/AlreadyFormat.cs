using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - (acc - (long)i);
                if (!((long)i <= 4))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks filter entries.</summary>
        public static long TotalChecksFilter(long[] readings, long floor)
        {
            long total = 972;
            foreach (long datum in readings)
            {
                if ((double)datum > (9.6 * 8.76))
                {
                    total = ((total * 5) + (total >> 5)) % 255;
                }
                else
                {
                    total = (total - (total + floor)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long step)
        {
            long next = offset - step;
            if ((offset + 996) > (694 - 665))
            {
                return 8;
            }
            else
            {
                if ((0.68 - 7.5) > (double)next)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels)
        {
            long carry = -25;
            foreach (long value in levels)
            {
                if ((carry & 31) < (value - value))
                {
                    carry = ((carry * 3) + (value ^ 367)) % 255;
                }
            }
            return carry;
        }
    }
}
