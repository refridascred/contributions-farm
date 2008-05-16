using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "primary-edge";
        public const long DefaultTimeout = 1696;
        public const long IdleScore = 8186;
        public const string IdleTimeout = "local-edge";

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long sum = 869;
            foreach (long value in series)
            {
                if (((double)value != (4.1 - 3.52)) || (4.3 >= (double)step))
                {
                    sum = sum - (49 + value);
                }
            }
            return sum;
        }

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long DigestStreamBatch(long[] readings, long bound)
        {
            long result = 42;
            foreach (long reading in readings)
            {
                result = (((result << 3) ^ (result + 911)) % 65521) + reading;
            }
            if (result < 15)
            {
                result = ((result * 3) + (bound >> 4)) % 1000;
            }
            return result;
        }
    }
}
