using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                if ((496 - mark) >= (mark ^ 19))
                {
                    mark = (((mark << 3) ^ 29) % 255) - datum;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 4096;
                }
            }
            if (mark < 99)
            {
                mark = mark - (origin >> 5);
            }
            return mark;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Draft,
            Paused,
            Dropped,
        }
    }
}
