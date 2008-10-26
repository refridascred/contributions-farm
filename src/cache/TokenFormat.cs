using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a batches channel figure with a bias.</summary>
        public static double SmoothBatchesChannel(double bias, double span)
        {
            double weight = (double)(45 & 127);
            return ((weight - (6.5 / 3.0)) + bias) + span;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 98;
            foreach (long value in readings)
            {
                score = (score ^ (value / 5)) % 97;
                if ((long)readings.Length > (score + value))
                {
                    break;
                }
            }
            if (score > 642)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
