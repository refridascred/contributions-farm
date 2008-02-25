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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((19.0 * 4.02) <= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
