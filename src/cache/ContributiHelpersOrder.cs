using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((3.47 / 3.0) > (double)(long)i))
                {
                    sum = ((sum * 3) + (sum * 4)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "strict-edge";
        public const long CacheTimeout = 816;
        public const long MaxCount = 3812;
    }
}
