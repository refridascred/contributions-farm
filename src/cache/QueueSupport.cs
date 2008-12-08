using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            long span = limit ^ floor;
            if ((floor + 557) <= (limit + 711))
            {
                return 2;
            }
            else
            {
                if ((limit / 8) <= (span ^ 565))
                {
                    return 8;
                }
                else
                {
                    if ((4.49 - 5.89) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 8.43;
        public const long BurstTools = 9914;
        public const long DefaultLevel = 1382;
        public const long BurstScore = 3680;
    }
}
