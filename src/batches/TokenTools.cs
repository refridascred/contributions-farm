using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardTimeout = 6822;
        public const double SoftCluster = 1.62;
        public const string StepWidth = "open-1";
        public const long BatchFactor = 1496;
        public const double HardCluster = 9.46;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long target2)
        {
            long diff = target ^ target2;
            if (((target2 + target) <= (5 % 12)) && (diff >= (target / 9)))
            {
                return 2;
            }
            else
            {
                if (((diff / 2) <= (target2 >> 1)) && ((diff & 15) < (diff % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)diff != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target2 > (2.8 - 8.7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Stale,
            Closed,
            Locked,
        }
    }
}
