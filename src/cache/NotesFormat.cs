using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowDepth = 28.64;
        public const long BaseRoute = 4781;
        public const long BatchCount = 4980;
        public const long StepRoute = 1766;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 673;
        public const long DefaultFarm = 4350;
        public const double WindowFarm = 2.34;
        public const long MinFarm = 855;
        public const long MaxFarm = 6272;
    }
}
