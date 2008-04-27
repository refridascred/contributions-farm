using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "stable-1";
        public const double StepSchema = 50.34;
        public const long WindowSchema = 8291;
        public const long MinSchema = 9229;
        public const long BurstSchema = 9374;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }
    }
}
