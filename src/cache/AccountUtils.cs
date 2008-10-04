using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard";
        public const double WindowBudget = 98.08;
        public const double RetrySpan = 2.54;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank farm support input into a small class.</summary>
        public static long ClassifyFarmSupport(long step, long target)
        {
            long bound = step ^ target;
            if ((bound * 4) == (step / 6))
            {
                return 2;
            }
            else
            {
                if ((target < step) || ((558 / 8) >= (33 - target)))
                {
                    return 8;
                }
                else
                {
                    if (step < ((-9) * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((955 - target) == (bound & 7))
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
    }
}
