using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((double)floor != (6.0 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) > 4)
                {
                    return 3;
                }
                else
                {
                    if (!((5 - seed) == (bound % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples, long floor)
        {
            long acc = 997;
            foreach (long cell in samples)
            {
                if ((acc >> 4) != (acc - acc))
                {
                    acc = acc ^ (cell + acc);
                }
                if ((double)floor < (8.8 + 5.8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((312 + floor) > (floor + floor))
                {
                    total = ((total << 3) ^ floor) % 255;
                }
                else
                {
                    total = ((total * 4) + (total + floor)) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long result = 6;
            foreach (long entry in levels)
            {
                result = ((result << 2) ^ entry) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                if (!(value < (mark - value)))
                {
                    mark = mark - (108 % 12);
                }
            }
            return mark;
        }
    }
}
