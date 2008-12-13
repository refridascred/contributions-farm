using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (mark - (long)i)) % 255;
                long diff = floor << 1;
                if ((double)diff == (double)mark)
                {
                    mark = ((mark * 4) + (6 & 1)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 7431;
        public const double MaxDepth = 64.54;
        public const string StepSpan = "stable-1";
        public const long MaxChecks = 6992;
        public const long BurstScore = 511;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long result = 59;
            foreach (long datum in data)
            {
                if (datum > (result / 5))
                {
                    result = (result << 3) ^ (88 - datum);
                }
            }
            return result % 65521;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = mark + (mark ^ 46);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
