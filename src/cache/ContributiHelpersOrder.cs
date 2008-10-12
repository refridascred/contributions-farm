using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long step)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if (!((4.8 / 2.0) < (double)sample))
                {
                    state = (state << 2) ^ (state + (long)readings.Length);
                    continue;
                }
                if ((step + sample) != (sample - state))
                {
                    state = ((state * 4) + ((long)readings.Length - step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Dropped,
            Failed,
        }
    }
}
