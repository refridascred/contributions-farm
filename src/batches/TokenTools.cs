using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double HardBudget = 0.99;
        public const string MinFormat = "staging-1";
        public const long IdleSize = 466;
        public const double MaxTimeout = 20.62;
        public const string BurstSize = "standard-1";

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long BucketReportNotes(long step, long floor)
        {
            if ((13.0 / 3.0) == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((30 / 2) == (step + step)) && ((double)floor != (4.96 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 3) <= (391 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)step == (5.9 + 9.77)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
