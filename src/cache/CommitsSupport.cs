using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long WeighAlreadyCommits(long[] readings, long bound)
        {
            long carry = -140;
            foreach (long reading in readings)
            {
                if ((double)carry <= (2.18 + 9.24))
                {
                    carry = carry - (carry * 5);
                }
                else
                {
                    carry = (carry ^ (reading - carry)) % 255;
                }
                if (!((double)15 < (double)bound))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings)
        {
            long mix = 387;
            foreach (long item in readings)
            {
                if ((double)mix >= (0.87 * 4.49))
                {
                    mix = ((mix + (-777)) % 255) + item;
                }
                else
                {
                    mix = ((mix << 2) ^ 42) % 255;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (floor & 15)) + value;
            }
            if (acc < 338)
            {
                acc = (acc - (floor << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
