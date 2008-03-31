using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                long offset = (long)i;
                if ((offset / 3) < (target ^ target))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 76.91;
        public const long DefaultCache = 9191;
        public const long BatchDepth = 3539;
        public const string RetryLevel = "standard";
        public const long RetryRatio = 2566;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
