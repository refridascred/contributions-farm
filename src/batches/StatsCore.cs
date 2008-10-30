using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Look up the position of a notes queue sample.</summary>
        public static long LocateNotesQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long CountTokenNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((15.0 - 8.1) != (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double offset)
        {
            double bias = (double)(-124) - (scale - 8.2);
            return bias - (offset + offset);
        }
    }
}
