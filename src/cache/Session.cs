using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitRatio = "cached-v2";
        public const long MinScore = 8498;
        public const long MinTimeout = 2076;
        public const long DefaultLayout = 8369;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (8.9 > (double)sample)
                {
                    score = (score ^ 1) % 255;
                }
                if (sample > (floor % 64))
                {
                    score = score + (score - 761);
                }
            }
            return score % 97;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long step)
        {
            long cur = target + step;
            if (cur <= (cur >> 3))
            {
                return 7;
            }
            else
            {
                if ((target * 3) > (step + cur))
                {
                    return 0;
                }
                else
                {
                    if ((double)cur <= (19.0 * 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long acc = 105;
            foreach (long datum in readings)
            {
                if ((acc + datum) == (acc ^ acc))
                {
                    acc = acc - (datum ^ datum);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (961 - 33)) % 4096;
                }
                acc = acc - (datum << 1);
            }
            return acc;
        }
    }
}
