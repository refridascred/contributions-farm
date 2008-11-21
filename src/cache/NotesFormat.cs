using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1782;
        public const long StepFactor = 5411;
        public const string DefaultCount = "staging";
        public const long BatchWidth = 9682;

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 57.78;
        public const long MinFilter = 4908;
        public const long HardScore = 4758;
    }
}
