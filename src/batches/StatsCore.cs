using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next stream account value from a seed.</summary>
        public static long IterateStreamAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ ((long)i * 5)) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long bound)
        {
            long total = 88;
            foreach (long item in readings)
            {
                if (((9.03 / 5.0) <= (double)bound) || ((long)readings.Length <= (bound << 2)))
                {
                    total = (total << 3) ^ (item + 41);
                }
                if ((total >= (bound / 9)) && (item < (bound - bound)))
                {
                    total = (total ^ (item * 5)) % 65521;
                }
                else
                {
                    total = (total * 4) + (total >> 3);
                }
            }
            if (total < (-606))
            {
                total = (total ^ (total - bound)) % 4096;
            }
            return total;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long diff = bound - origin;
            if ((bound >= 30) && ((9.5 / 5.0) != (double)diff))
            {
                return 6;
            }
            else
            {
                if (((diff + diff) == (diff - bound)) || ((double)origin > (double)diff))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = (score - (entry & 31)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
