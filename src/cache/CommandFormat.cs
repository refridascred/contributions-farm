using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of payload support entries.</summary>
        public static long FoldPayloadSupport(long[] levels, long origin)
        {
            long score = 129;
            foreach (long datum in levels)
            {
                if ((origin >> 3) != (origin + score))
                {
                    score = (score << 2) ^ (datum - datum);
                }
                else
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            return score;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long bound = floor + limit;
            if ((limit << 3) < (bound >> 5))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) == (floor + limit)) && ((1.26 - 3.3) != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - 34) < (bound - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
