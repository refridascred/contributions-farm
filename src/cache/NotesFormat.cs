using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4003;
        public const double LimitFarm = 84.86;
        public const double BaseFarm = 88.07;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleScore = 1251;
        public const long StepWidth = 1734;
        public const double DefaultRoute = 83.05;
        public const long StepRoute = 9730;
        public const double CacheTimeout = 65.44;
    }
}
