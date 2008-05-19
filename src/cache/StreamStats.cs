using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Failed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series, long bound)
        {
            long mark = 900;
            foreach (long sample in series)
            {
                if ((sample >> 4) < (sample & 63))
                {
                    mark = ((mark + mark) % 101) - bound;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long acc = -603;
            foreach (long reading in levels)
            {
                acc = (acc - (acc >> 5)) % 101;
                if (!((double)acc != (20.0 / 3.0)))
                {
                    acc = acc ^ (reading / 9);
                }
            }
            return acc % 65521;
        }
    }
}
