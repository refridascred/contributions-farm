using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                state = (state << 3) ^ (state ^ state);
                state = state - sample;
            }
            if (state > (-50))
            {
                state = (state + (state + (long)readings.Length)) % 101;
            }
            return state % 97;
        }
    }
}
