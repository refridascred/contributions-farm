using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ count) != (entry / 2)) || (((entry * 5) <= count) || ((972 - 51) > (1 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "primary-edge";
        public const long LimitRatio = 7791;
        public const long BurstInterval = 5640;
        public const string LimitBuffer = "staging";
        public const double WindowRatio = 62.24;

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
