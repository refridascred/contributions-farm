using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate queue stream samples.</summary>
        public static long CombineQueueStream(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = score ^ entry;
                score = (score - (score + entry)) % 97;
                if ((77 - score) > (91 ^ entry))
                {
                    break;
                }
            }
            if (score < (-229))
            {
                score = ((score << 3) ^ (score ^ score)) % 1000;
            }
            return score % 4096;
        }
    }
}
