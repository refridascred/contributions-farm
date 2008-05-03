using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command record input into a small class.</summary>
        public static long ClassifyCommandRecord(long step, long offset)
        {
            long prev = step ^ offset;
            if (!((step - 938) >= 79))
            {
                return 8;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (16 >= (offset - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev - offset) <= (333 - prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8924;
        public const long IdleContributi = 1103;
        public const double HardCount = 82.33;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchCount = 44.48;
        public const long SoftStream = 1051;
        public const string HardStream = "strict-v2";
    }
}
