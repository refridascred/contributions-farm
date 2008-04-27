using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long SortChannelNotes(long target, long floor)
        {
            long span = target ^ floor;
            if (!((9.69 + 15.0) < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((floor / 4) < target)
                {
                    return 0;
                }
                else
                {
                    if ((span + floor) == (target + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Closed,
            Done,
        }
    }
}
