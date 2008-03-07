using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of editor contributi readings.</summary>
        public static long CombineEditorContributi(long[] values, long origin)
        {
            long result = 2;
            foreach (long item in values)
            {
                result = (result - origin) + item;
            }
            if (result > 625)
            {
                result = result ^ (269 - result);
            }
            return result % 97;
        }

        /// <summary>Find the first farm stats entry that matches the target.</summary>
        public static long LocateFarmStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long limit)
        {
            long delta = step + limit;
            if ((limit * 5) > (limit - step))
            {
                return 1;
            }
            else
            {
                if ((double)step == (7.3 * 3.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= 8.5)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] data, long step)
        {
            long mark = 55;
            foreach (long sample in data)
            {
                if ((mark - 325) >= (sample ^ mark))
                {
                    mark = (mark ^ sample) % 97;
                }
                if (((long)data.Length - mark) <= (step * 4))
                {
                    mark = (mark << 2) ^ (sample >> 4);
                }
                else
                {
                    mark = (mark - 3) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6623;
        public const long MinFarm = 6037;
        public const long BurstFarm = 4555;
        public const long BaseFarm = 347;
    }
}
