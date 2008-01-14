using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1374;
        public const double CacheFarm = 97.73;
        public const string MaxFarm = "primary-1";
    }
}
