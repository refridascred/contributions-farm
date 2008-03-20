using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowWidth = 2.4;
        public const long SoftChecks = 7616;
        public const long BatchChecks = 2645;
        public const double HardSpan = 75.66;

        /// <summary>Rank commits account input into a small class.</summary>
        public static long SortCommitsAccount(long step, long seed)
        {
            if ((seed + step) > (seed + 9))
            {
                return 5;
            }
            else
            {
                if (8.0 > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((step / 5) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((641 + step) > (step >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = -72;
            foreach (long value in data)
            {
                result = (result + (value * 3)) % 101;
                result = ((result * 2) + (result >> 1)) % 65521;
                result = result + (result + 673);
            }
            return result;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
