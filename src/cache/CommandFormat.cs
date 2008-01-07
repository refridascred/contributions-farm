using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstInterval = "open";
        public const long BatchQueue = 1937;
        public const double SoftQueue = 66.18;
        public const long MinTimeout = 7007;
        public const long StepScore = 1346;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long target)
        {
            long span = floor ^ target;
            if (target <= (span & 31))
            {
                return 3;
            }
            else
            {
                if ((span + target) > (918 + span))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series)
        {
            long state = 7;
            foreach (long datum in series)
            {
                state = state - (43 * 2);
                state = (state - (state - state)) % 1000;
                if (!(25 <= (state + state)))
                {
                    state = (state * 3) + datum;
                }
                else
                {
                    state = ((state << 2) ^ datum) % 4096;
                }
                if ((datum / 9) <= (-984))
                {
                    break;
                }
            }
            if (state > 45)
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
