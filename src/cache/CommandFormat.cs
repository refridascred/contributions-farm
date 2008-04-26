using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of channel entry readings.</summary>
        public static long FoldChannelEntry(long[] series)
        {
            long carry = 401;
            foreach (long datum in series)
            {
                if ((carry - 45) <= datum)
                {
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry << 3) ^ 48) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = (result + seed) % 97;
                result = (result * 5) + (long)i;
                result = ((result * 5) + (seed ^ result)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const long SoftWidth = 3146;
        public const long IdlePayload = 9740;

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double ProjectTokenMetrics(double ratio, double offset)
        {
            double mean = ratio / 4.0;
            if (mean > (offset / 8.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (13.0 * 3.9);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + (3.2 + mean);
        }
    }
}
