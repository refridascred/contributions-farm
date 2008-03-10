using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Retry,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long state = 48;
            foreach (long item in series)
            {
                if (((state + item) < (offset * 5)) && ((item + 54) != (state - offset)))
                {
                    state = (state * 3) + (offset & 3);
                }
            }
            if (state > 92)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
