using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (offset + gain2))
            {
                gain2 = gain2 + (gain + 7.5);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)75) + (double)(long)i;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Draft,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7092;
        public const double BatchCount = 35.66;
        public const long RetryBuffer = 7412;
        public const string StepBuffer = "alpha-1";
        public const long DefaultBuffer = 8492;

        /// <summary>Match up contributi support samples.</summary>
        public static long OverlapContributiSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
