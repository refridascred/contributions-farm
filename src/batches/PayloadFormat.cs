using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count == (double)floor)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long limit)
        {
            long offset = step ^ limit;
            if (offset <= 43)
            {
                return 6;
            }
            else
            {
                if ((step + 14) >= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= 2.3)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((1.74 + 19.0) == (double)limit) && ((limit / 8) == (600 + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepScore = 7115;
        public const double HardScore = 55.77;
        public const double BatchChannel = 98.85;
        public const double BaseFactor = 20.53;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFactor = 3.44;
        public const long HardFormat = 8441;
        public const long LimitFormat = 2076;
    }
}
