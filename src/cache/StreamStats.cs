using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long floor)
        {
            long next = bound + floor;
            if ((bound + bound) <= (bound ^ floor))
            {
                return 8;
            }
            else
            {
                if ((next >> 3) != (bound / 7))
                {
                    return 3;
                }
                else
                {
                    if ((bound + next) > (bound << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long result = 510;
            foreach (long value in readings)
            {
                result = (result ^ value) % 1000;
                if ((value << 2) < (result / 2))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
