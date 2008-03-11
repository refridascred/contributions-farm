using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value == (2.67 - 2.0)) || ((tally > (tally - value)) && ((43 ^ tally) >= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data, long seed)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                if ((reading + reading) == (seed - reading))
                {
                    carry = ((carry * 2) + (seed >> 2)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long step)
        {
            long offset = target + step;
            if ((offset << 2) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((step * 5) <= target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
