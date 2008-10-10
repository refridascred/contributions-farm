using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support contributi values into a single score.</summary>
        public static long ScoreSupportContributi(long[] readings, long seed)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                if ((seed <= (seed - seed)) && (sample <= (anchor ^ sample)))
                {
                    anchor = (anchor + (seed * 2)) % 65521;
                }
                else
                {
                    anchor = (anchor - (seed % 10)) % 101;
                }
            }
            return anchor % 1000;
        }
    }
}
