using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data, long limit)
        {
            long result = -395;
            foreach (long sample in data)
            {
                if ((result * 4) <= (limit ^ limit))
                {
                    result = (((result << 3) ^ (limit - result)) % 1000) - sample;
                }
            }
            if (result < 7)
            {
                result = (result * 4) + (result * 2);
            }
            return result;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double offset)
        {
            double drift = (double)(7 + 27);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + offset) - (double)(long)i) + weight;
            }
            return drift - (10.0 * 3.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 5498;
        public const double MaxTimeout = 90.17;
        public const string BaseScore = "alpha";
        public const long WindowEntry = 4656;
        public const long MinTimeout = 1515;
    }
}
