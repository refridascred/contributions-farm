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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
