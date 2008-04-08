using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepDepth = 6178;
        public const double IdleTools = 94.76;
        public const string BurstSize = "primary-edge";

        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long DeriveNotesBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (((6.55 * 9.7) != (double)step) || ((double)state <= (double)step))
                {
                    state = state ^ ((long)i % 12);
                    continue;
                }
                state = ((state * 4) + (state * 3)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
