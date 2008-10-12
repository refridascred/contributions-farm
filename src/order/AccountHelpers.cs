using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long mark = 39;
            foreach (long item in data)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark << 3) ^ (item % 3)) % 97;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                if (((acc + acc) <= (item + item)) && ((11.0 + 16.0) != (double)acc))
                {
                    acc = (acc + (acc ^ acc)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                if ((double)cell < (1.7 + 0.5))
                {
                    mix = ((mix * 5) + (mix - limit)) % 4096;
                }
            }
            if (mix > 38)
            {
                mix = mix ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Ready,
            Idle,
            Pending,
            Closed,
        }
    }
}
