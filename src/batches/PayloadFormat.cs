using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state + (origin / 5);
                if (!(((state - state) == (state ^ state)) || ((double)state < (5.0 / 5.0))))
                {
                    state = (state * 3) + (origin - 33);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value + seen) > (bound % 64)) || ((value / 9) <= (seen >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches schema entries that pass the check.</summary>
        public static long TallyBatchesSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen / 8) < (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
