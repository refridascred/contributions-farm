using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a tools commits sample.</summary>
        public static long LocateToolsCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long CountWindowProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (12.0 - 6.9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
