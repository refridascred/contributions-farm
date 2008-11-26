using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if (!(2.14 > (double)step))
                {
                    score = (score - (step + 55)) % 65521;
                    score = (score << 2) ^ (score - score);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long SortChecksCounter(long bound, long seed)
        {
            long next = bound ^ seed;
            if (!((double)seed != (2.8 + 1.2)))
            {
                return 1;
            }
            else
            {
                if ((next * 4) >= (114 - next))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (4.5 - 0.5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
