using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long step2)
        {
            long span = step ^ step2;
            if (9 >= (step ^ 7))
            {
                return 6;
            }
            else
            {
                if ((101 >> 4) < (step + 81))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 * 4) == (span + step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = ((mix - value) % 255) + origin;
            }
            return mix;
        }
    }
}
