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

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long TallyFarmNotes(long[] readings, long target)
        {
            long score = 12;
            foreach (long item in readings)
            {
                score = ((score ^ (9 >> 1)) % 97) + target;
                if ((item - (long)readings.Length) != (269 * 4))
                {
                    break;
                }
            }
            return score % 97;
        }

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
