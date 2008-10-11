using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long state = 538;
            foreach (long cell in data)
            {
                if (61 <= (state + (long)data.Length))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many already context samples are out of range.</summary>
        public static long TallyAlreadyContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value - 1) < (value - value)) && !((tally - tally) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
