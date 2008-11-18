using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 10.12;
        public const long LimitCommand = 3347;
        public const long MaxSize = 5863;
        public const long DefaultFactor = 3087;
        public const long HardCommand = 7401;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long SeriesReportEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + result) >= result)
                {
                    result = (result ^ result) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
