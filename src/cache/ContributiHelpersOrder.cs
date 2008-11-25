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

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1102;
        public const long WindowNotes = 1932;
        public const string IdleNotes = "latest-v2";
    }
}
