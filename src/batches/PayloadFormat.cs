using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer support input into a small class.</summary>
        public static long SortBufferSupport(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((-482) <= span)
            {
                return 3;
            }
            else
            {
                if ((span << 1) <= (origin - origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed != (0.4 - 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.79 + 3.96) < (double)span)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Active,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits << 3) == (datum >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format commits series from a seed.</summary>
        public static long StepFormatCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((9.79 - 14.0) != (double)mix) && ((mix % 7) > bound))
                {
                    mix = mix + (99 + (long)i);
                    mix = ((mix * 5) + bound) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
