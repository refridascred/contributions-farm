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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step / 7) >= (hits - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "open-edge";
        public const long BurstEntry = 4808;
        public const long StepInterval = 3892;

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
