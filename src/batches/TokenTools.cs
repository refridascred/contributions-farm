using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long state = 308;
            foreach (long item in data)
            {
                if ((2.46 / 2.0) > (double)item)
                {
                    state = (state - (offset + state)) % 101;
                }
                if ((item % 5) > (offset / 9))
                {
                    break;
                }
            }
            if (state < 25)
            {
                state = ((state * 4) + offset) % 97;
            }
            return state;
        }
    }
}
