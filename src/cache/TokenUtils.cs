using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFactor = 22.44;
        public const double WindowDepth = 9.36;
        public const string IdleFarm = "alpha";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinSize = 87.74;
        public const long HardWidth = 7352;
        public const long WindowRoute = 2251;
    }
}
