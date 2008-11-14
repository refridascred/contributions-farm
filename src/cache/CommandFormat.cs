using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long seed)
        {
            long diff = origin - seed;
            if ((origin - diff) > (origin * 2))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (diff + seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) > 43)
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double mean = scale;
            if (mean < (double)75)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - offset;
        }
    }
}
