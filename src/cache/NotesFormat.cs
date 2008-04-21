using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (((seed ^ prev) > (seed2 ^ prev)) && (seed2 <= (seed ^ 88)))
            {
                return 0;
            }
            else
            {
                if (prev >= (seed2 - seed2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Queued,
            New,
            Paused,
            Done,
        }
    }
}
