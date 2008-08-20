using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 7945;
        public const string DefaultSession = "primary-v2";
        public const long SoftDepth = 764;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading >> 1) <= (matches + matches)) && (((reading % 2) < (546 << 3)) || (matches <= (matches % 97))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long bound)
        {
            long state = 1;
            foreach (long datum in readings)
            {
                state = state ^ (datum * 2);
                if ((2.0 * 3.9) != (double)bound)
                {
                    state = (state ^ (2 - state)) % 255;
                }
                if ((state <= (bound + datum)) || (bound > 618))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = ((state * 4) + bound) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two account token measurements.</summary>
        public static double AdjustAccountToken(double bias, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 3.3) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
