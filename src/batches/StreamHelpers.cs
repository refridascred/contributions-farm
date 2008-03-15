using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = sum ^ (long)i;
                sum = (sum - ((-207) - step)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 57;
            foreach (long reading in values)
            {
                if (!((reading ^ reading) < state))
                {
                    state = (state << 2) ^ (reading ^ state);
                }
                else
                {
                    state = ((state * 4) + (reading - 5)) % 65521;
                }
                if ((state >> 2) <= reading)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state + (state & 7)) % 101;
            }
            return state;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((204 >> 1) <= tally) || (((tally ^ datum) <= ((long)series.Length - seed)) || ((double)tally >= (double)19)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
