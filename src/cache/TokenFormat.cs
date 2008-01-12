using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long TallyPayloadWindowGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long SortBufferEditor(long floor, long step)
        {
            long offset = floor - step;
            if (((double)floor > (4.76 * 0.5)) || ((floor + step) <= step))
            {
                return 0;
            }
            else
            {
                if ((step < floor) || ((83 - offset) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
