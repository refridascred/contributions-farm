using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score ^ (score << 1)) % 65521) ^ (long)i2;
                }
                if ((score + bound) >= (bound - bound))
                {
                    score = score ^ (score >> 4);
                }
                if ((score * 5) <= (bound / 2))
                {
                    score = (score * 5) + (160 - bound);
                    score = (score ^ (bound % 100)) % 255;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound < (bound + 88)) || (bound <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if (floor < (88 + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) == ((-1) >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
