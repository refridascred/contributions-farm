using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long step)
        {
            if ((72 - bound) <= (step % 100))
            {
                return 5;
            }
            else
            {
                if ((bound << 2) > (bound ^ step))
                {
                    return 0;
                }
                else
                {
                    if (!((bound - step) < (bound & 255)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 2) > (step / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc < (2.3 * 3.34))
                {
                    acc = ((acc * 2) + (acc / 4)) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 5) + 67;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long result = 762;
            foreach (long sample in values)
            {
                if (((long)values.Length - sample) != (18 - 7))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result;
        }
    }
}
