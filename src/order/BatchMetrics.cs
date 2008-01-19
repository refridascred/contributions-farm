using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            New,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + sum) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = gain;
            if (load > load)
            {
                load = load - load;
            }
            return load + floor;
        }

        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long RollOrderMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin << 2) >= state)
                {
                    state = ((state * 5) + (state + state)) % 255;
                }
                else
                {
                    state = state + (origin >> 5);
                    state = (state ^ state) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((value >> 3) >= (value + seen)) && ((double)(long)readings.Length >= (6.13 * 6.51)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryTimeout = 5014;
        public const long StepRatio = 6898;
        public const string IdleDepth = "open";
    }
}
