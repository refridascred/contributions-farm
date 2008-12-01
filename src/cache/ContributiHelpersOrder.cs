using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + 9.0;
            }
            return drift + 2.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseBudget = 2680;
        public const long BurstFarm = 2455;
        public const double StepFarm = 43.45;
        public const string BatchFarm = "strict-edge";
        public const double StepInterval = 96.23;

        /// <summary>Compare every pair of already context readings.</summary>
        public static long CompareAlreadyContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
