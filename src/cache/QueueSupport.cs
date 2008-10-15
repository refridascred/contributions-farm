using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long limit)
        {
            long anchor = -35;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + anchor)) + limit;
                if ((689 / 6) != (anchor + value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (long)readings.Length)
                {
                    sum = ((sum * 4) + seed) % 101;
                    sum = (sum + seed) % 4096;
                }
                sum = ((sum * 4) + entry) % 65521;
            }
            if (sum < 664)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
