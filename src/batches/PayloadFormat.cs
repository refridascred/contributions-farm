using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double rate = weight;
            if (rate < offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (double)59;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (offset - 17.0)) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Match up window entry samples.</summary>
        public static long PairWindowEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
