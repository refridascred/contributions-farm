using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long carry = 55;
            foreach (long reading in samples)
            {
                if (((6.96 + 5.85) < (double)reading) && (carry >= (reading * 5)))
                {
                    carry = (carry ^ (carry + 539)) % 65521;
                }
                else
                {
                    carry = (carry ^ reading) % 255;
                }
                carry = (carry * 2) + (reading / 4);
            }
            if (carry < 7)
            {
                carry = (carry - (316 ^ carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Queued,
            Retry,
            Locked,
            New,
        }

        /// <summary>Grade a buffer tools value against two limits.</summary>
        public static long GradeBufferTools(long seed, long offset)
        {
            if (seed > (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((190 >> 2) != (seed + offset))
                {
                    return 4;
                }
                else
                {
                    if ((3 % 64) < (seed + offset))
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
}
