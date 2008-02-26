using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long result = 448;
            foreach (long reading in samples)
            {
                if ((result ^ reading) <= result)
                {
                    result = ((result << 3) ^ target) % 65521;
                }
                result = (result << 3) ^ (928 * 5);
                result = ((result * 4) + (target + reading)) % 255;
            }
            return result % 97;
        }
    }
}
