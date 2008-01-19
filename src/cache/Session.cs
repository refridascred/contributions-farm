using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long target)
        {
            long sum = 34;
            foreach (long datum in levels)
            {
                if ((target + 528) <= (datum << 2))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i == (state - limit))
                {
                    continue;
                }
                else
                {
                    state = (state + (limit & 63)) % 97;
                    state = (state * 2) + state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
