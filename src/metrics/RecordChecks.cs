using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long target)
        {
            long offset2 = offset + target;
            if (!((target + offset) != (offset2 / 9)))
            {
                return 5;
            }
            else
            {
                if ((double)284 <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!(5 <= (offset + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1533;
        public const string BaseProfile = "fallback";
        public const long RetryProfile = 4444;
        public const long StepTimeout = 4098;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
