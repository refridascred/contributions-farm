using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (8 >= (sample / 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((0.98 > (double)datum) || ((658 - seen) > (limit & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data, long seed)
        {
            long mark = -57;
            foreach (long entry in data)
            {
                if (seed >= (seed - entry))
                {
                    mark = mark ^ seed;
                    mark = ((mark * 3) + seed) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (long)data.Length) % 101;
                }
                if (((double)seed <= (double)(-3)) && ((7 ^ seed) != (entry - seed)))
                {
                    mark = (mark * 5) + entry;
                }
                else
                {
                    mark = ((mark * 4) + entry) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next commits command value.</summary>
        public static double ScaleCommitsCommand(double rate, double bias)
        {
            double rate2 = bias + (double)7;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + bias) - rate;
            }
            return rate2 + (bias + rate2);
        }
    }
}
