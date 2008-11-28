using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step & 31) <= mix)
                {
                    mix = (mix ^ (step - mix)) % 101;
                    mix = ((mix * 4) + (mix - step)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((2.6 * 2.0) >= (double)anchor) || ((anchor << 3) < anchor))
                {
                    anchor = ((anchor << 3) ^ bound) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if ((acc << 2) >= (acc - acc))
                {
                    acc = (acc + (acc >> 3)) % 255;
                }
                if (!((double)item > (9.0 - 7.4)))
                {
                    acc = (acc ^ (item - acc)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((bound * 4) == (bound ^ 34))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a format commits pair into a bucket.</summary>
        public static long SortFormatCommits(long bound, long seed)
        {
            long cur = bound - seed;
            if (((8.0 / 8.0) != (double)cur) && ((double)cur > (6.06 - 1.4)))
            {
                return 1;
            }
            else
            {
                if ((cur ^ cur) < (79 * 5))
                {
                    return 0;
                }
                else
                {
                    if (((seed + cur) == (3 + bound)) && (bound > (seed >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < (bound + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
