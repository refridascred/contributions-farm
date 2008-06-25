using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3664;
        public const double LimitToken = 68.45;
        public const long HardWidth = 5851;
        public const long HardDepth = 5692;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            New,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 5638;
        public const long IdleEditor = 1189;
        public const string HardSpan = "local-v2";
        public const string StepBudget = "fallback";
        public const long BurstInterval = 653;
    }
}
