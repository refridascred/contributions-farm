using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up queue schema samples.</summary>
        public static long CompareQueueSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long state = 536;
            foreach (long reading in levels)
            {
                if (((3.64 * 1.6) <= (double)state) || ((state << 1) > (reading & 7)))
                {
                    state = state + (reading ^ state);
                }
                state = state + (state + reading);
            }
            return state % 65521;
        }
    }
}
