using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            New,
            Active,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the commits cluster series from a seed.</summary>
        public static long RollCommitsCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((double)state >= (3.0 * 12.0))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    state = (state - ((long)i << 1)) ^ (long)i3;
                    state = state - (99 << 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
