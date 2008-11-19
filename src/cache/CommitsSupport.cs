using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long sum = 57;
            foreach (long cell in samples)
            {
                sum = sum ^ cell;
                if ((3 >> 1) <= (cell << 2))
                {
                    sum = (sum - (cell + 8)) % 1000;
                }
                else
                {
                    sum = ((sum * 5) + (sum * 3)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings, long origin)
        {
            long state = 531;
            foreach (long cell in readings)
            {
                state = state ^ (cell + state);
                state = (state + (state + state)) % 97;
                if ((4.5 * 4.94) > (double)origin)
                {
                    break;
                }
            }
            if (state > 69)
            {
                state = (state * 4) + 4;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7420;
        public const string SoftWidth = "primary-1";
        public const long LimitRecord = 7375;
        public const string SoftFactor = "strict";
        public const long IdleRecord = 2851;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - limit) > (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (4.0 - 7.5))
                {
                    return 6;
                }
                else
                {
                    if ((2.0 + 3.1) <= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 1) < limit) && ((limit ^ step) == (lane & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (seed <= (seed / 2))
                {
                    total = (total + (seed - 1)) % 65521;
                    total = (total - (long)i) % 255;
                }
                else
                {
                    long count = (seed ^ seed) << 2;
                    total = total ^ (count & 63);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
