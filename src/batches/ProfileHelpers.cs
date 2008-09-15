using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double drift = ratio / 9.0;
            if (drift < offset)
            {
                drift = drift - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - (double)42;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2237;
        public const long SoftContext = 1717;
        public const long MinContext = 624;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 2804;
        public const double MinGithubfarm = 5.56;
        public const long SoftGithubfarm = 6329;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long limit)
        {
            long mix = 327;
            foreach (long datum in levels)
            {
                if ((limit & 127) > (datum >> 2))
                {
                    mix = mix - 7;
                }
                mix = mix ^ (datum >> 3);
            }
            if (mix < 14)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Draft,
            Locked,
            Retry,
            New,
        }
    }
}
