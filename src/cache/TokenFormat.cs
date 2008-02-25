using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context already samples are out of range.</summary>
        public static long CountContextAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long OverlapRecordToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + ((long)i << 1)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
