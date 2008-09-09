using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) < (464 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Closed,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double rate = 7.0;
            if (rate < rate)
            {
                rate = rate - 1.84;
            }
            else
            {
                rate = rate - 7.3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (span / 6.0)) + (double)(long)i;
            }
            return rate + (scale + span);
        }
    }
}
