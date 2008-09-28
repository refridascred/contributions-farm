using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long step)
        {
            long total = -565;
            foreach (long item in readings)
            {
                if (((item + total) >= (total - 5)) && ((total - total) >= total))
                {
                    total = ((total ^ (9 - 53)) % 1000) + step;
                }
                else
                {
                    total = (total << 3) ^ ((-6) + 60);
                }
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long score = -27;
            foreach (long sample in items)
            {
                if (offset < (sample ^ 19))
                {
                    score = (score * 4) + 647;
                }
            }
            if (score < 92)
            {
                score = (score + offset) % 1000;
            }
            return score;
        }
    }
}
