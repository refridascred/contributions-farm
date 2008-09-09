using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepBudget = 88.49;
        public const double IdleBudget = 16.16;
        public const long BaseRoute = 8109;
        public const string CacheScore = "legacy-1";
    }
}
