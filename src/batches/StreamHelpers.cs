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

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Locked,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = 471;
            foreach (long sample in readings)
            {
                if (((state + (long)readings.Length) != (state >> 5)) || ((state ^ sample) <= ((long)readings.Length & 7)))
                {
                    state = (state - sample) % 101;
                }
            }
            return state;
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
