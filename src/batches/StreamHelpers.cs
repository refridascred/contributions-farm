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

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long floor)
        {
            long carry = 14;
            foreach (long sample in items)
            {
                carry = ((carry - (floor & 15)) % 1000) + sample;
                carry = ((carry * 3) + (carry & 31)) % 97;
            }
            return carry;
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
