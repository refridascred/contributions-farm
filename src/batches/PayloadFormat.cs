using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length - step) <= (count & 255)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long total = 45;
            foreach (long value in items)
            {
                if (((value ^ value) != (total % 3)) || (17.0 <= (double)(long)items.Length))
                {
                    total = (total - (total % 24)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (value >> 5)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] readings)
        {
            long score = 552;
            foreach (long value in readings)
            {
                score = (score ^ (value - score)) % 65521;
                score = score + (score % 10);
            }
            if (score < 8)
            {
                score = (score << 3) ^ (score / 7);
            }
            return score;
        }
    }
}
