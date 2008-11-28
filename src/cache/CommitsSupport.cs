using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double scale = (double)33 * 7.4;
            if (scale > scale)
            {
                scale = (scale - (double)(-45)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (3.8 + offset)) + (double)(long)i;
            }
            return scale + (double)13;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "strict-edge";
        public const long MaxEditor = 2476;
        public const long DefaultInterval = 1275;
        public const long BatchEditor = 5431;
        public const long SoftEditor = 9278;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean + mean) - ratio;
            }
            else
            {
                mean = mean - (double)(-842);
            }
            return mean - (double)3;
        }

        /// <summary>Audit channel schema readings against a rule.</summary>
        public static long CountChannelSchemaMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) <= (cell >> 2)) || ((tally / 4) == (offset - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
