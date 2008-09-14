using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double scale, double offset)
        {
            double scale2 = 9.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            if ((6.7 - 12.0) >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step % 16) >= (seed - step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + ((long)i << 1)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
