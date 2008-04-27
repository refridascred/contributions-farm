using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (origin - origin)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Active,
            Done,
            Pending,
            New,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data, long target)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if ((16.0 - 1.0) < (double)mix)
                {
                    mix = (((mix << 3) ^ (49 % 8)) % 1000) ^ cell;
                }
            }
            if (mix > 49)
            {
                mix = (mix << 2) ^ (target - mix);
            }
            return mix % 65521;
        }
    }
}
