using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "fallback-edge";
        public const long WindowFactor = 5197;
        public const string SoftSpan = "staging-v2";
        public const long BatchCommand = 9825;
        public const long IdleCommand = 3612;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length >= (8.0 - 3.6))
                {
                    acc = acc + (reading / 4);
                }
                if ((acc >> 3) < (acc * 3))
                {
                    acc = ((acc * 5) + reading) % 101;
                }
            }
            if (acc > 170)
            {
                acc = acc - (82 + acc);
            }
            return acc;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 986;
            foreach (long item in data)
            {
                long diff = (item + item) * 4;
                if ((double)(long)data.Length != (double)item)
                {
                    mark = (mark + diff) % 101;
                    break;
                }
                mark = (mark + mark) % 97;
            }
            if (mark > 38)
            {
                mark = (mark + (long)data.Length) % 101;
            }
            return mark;
        }
    }
}
