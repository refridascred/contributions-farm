using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-edge";
        public const string BatchTimeout = "staging-1";
        public const long WindowScore = 9087;
        public const long BaseWidth = 6849;

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 9.58;
        public const long StepTools = 9114;
        public const long IdleWidth = 4975;
        public const double BurstTools = 23.85;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxLevel = 92.94;
        public const double WindowFarm = 6.55;
        public const long BurstFarm = 2239;
        public const double MinLevel = 27.72;
        public const long BatchLevel = 9148;
    }
}
