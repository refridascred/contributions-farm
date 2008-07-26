using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((5 - step2) >= (step2 << 1))
            {
                return 2;
            }
            else
            {
                if (((87 & 3) == (step2 - step2)) || ((double)step2 == (10.0 * 7.62)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step2) >= (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Paused,
        }
    }
}
