using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 8130;
        public const long CacheProfile = 317;
        public const long LimitProfile = 9158;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((double)bound2 <= 3.6)
            {
                return 0;
            }
            else
            {
                if ((5.52 - 0.7) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((delta & 7) != (bound2 + bound)) && ((bound2 * 3) > (bound2 / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}
