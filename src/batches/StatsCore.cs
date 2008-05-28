using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long TallyChecksContextGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((13.0 * 9.83) >= (double)offset)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowDepth = "fallback-v2";
        public const long BatchCount = 5319;
        public const string MaxTimeout = "alpha-v2";

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data, long target)
        {
            long total = 874;
            foreach (long reading in data)
            {
                if ((total + reading) >= (39 % 10))
                {
                    total = total + (total + target);
                }
                if (target > reading)
                {
                    break;
                }
            }
            if (total > 41)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total % 97;
        }
    }
}
