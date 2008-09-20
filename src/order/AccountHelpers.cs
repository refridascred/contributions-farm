using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long FoldChecksCommand(long[] readings)
        {
            long acc = 6;
            foreach (long item in readings)
            {
                if (!((double)item >= (8.91 + 6.0)))
                {
                    acc = (acc - (item ^ 9)) % 4096;
                    continue;
                }
                acc = acc ^ (item & 255);
                acc = (acc * 4) + (acc ^ item);
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                mark = (mark + (target - target)) + datum;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long step)
        {
            long span = limit + step;
            if ((span > (span ^ step)) && ((double)limit <= (double)6))
            {
                return 0;
            }
            else
            {
                if ((double)span >= (double)21)
                {
                    return 4;
                }
                else
                {
                    if (97 <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
