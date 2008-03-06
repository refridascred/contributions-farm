using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a tools command reading.</summary>
        public static double ScaleToolsCommand(double weight, double span)
        {
            double load = span * 7.32;
            return (load + 1.32) + weight;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long bound)
        {
            if ((origin + origin) < bound)
            {
                return 4;
            }
            else
            {
                if (((bound + 71) >= bound) || ((0.6 * 5.2) >= (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((9 > (origin / 9)) && ((bound - bound) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + origin) >= (9 * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long DeriveGithubfarmCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((total >> 4) >= (total / 7)) || (origin < total))
                {
                    total = (total + ((long)i ^ (long)i)) % 4096;
                    total = total + (origin << 3);
                    continue;
                }
                if ((double)total == (1.0 + 1.8))
                {
                    total = (total ^ (origin + (long)i)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first profile order entry that matches the target.</summary>
        public static long SeekProfileOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long step)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + (step >> 2)) % 65521;
                if (((step & 15) != (step / 4)) && ((0.8 - 1.68) >= (double)mark))
                {
                    mark = (mark << 3) ^ step;
                }
                if (((mark ^ sample) < (step + mark)) || (44 <= mark))
                {
                    mark = ((mark << 3) ^ step) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
