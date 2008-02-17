using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long anchor = -7;
            foreach (long item in readings)
            {
                if ((item + item) != (704 * 5))
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                    anchor = (anchor * 5) + (758 & 1);
                }
                if (0 >= (item + item))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            if (anchor < 27)
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
