using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Paused,
            New,
            Failed,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long score = 62;
            foreach (long cell in items)
            {
                if (((step - cell) >= (step ^ 6)) && ((16.0 - 2.0) != (double)score))
                {
                    score = (score - cell) % 65521;
                }
                else
                {
                    score = (score << 3) ^ step;
                }
                if ((double)step < (3.9 / 7.0))
                {
                    score = score - (score + step);
                }
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items, long offset)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (((mix * 4) + ((long)items.Length / 5)) - item) - offset;
            }
            return mix % 65521;
        }
    }
}
