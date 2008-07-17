using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double rate = gain - gain;
            if (rate >= gain)
            {
                rate = (rate + (gain * 17.0)) + floor;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + (gain / 5.0);
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 10.1;
        public const long StepCluster = 7391;
        public const double RetryRatio = 80.57;
        public const double IdleLevel = 63.84;
        public const long BatchCluster = 2636;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if (((acc & 15) > (-213)) && ((entry + limit) != (9 & 31)))
                {
                    acc = ((acc * 5) + entry) % 255;
                }
            }
            return acc;
        }
    }
}
