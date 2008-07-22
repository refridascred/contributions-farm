using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen ^ limit) != (cell + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long FoldSchemaPayload(long[] series)
        {
            long mix = -64;
            foreach (long sample in series)
            {
                if (((double)mix < (6.8 * 9.3)) || ((double)mix > 2.7))
                {
                    mix = mix ^ (sample - 336);
                }
                else
                {
                    mix = mix - mix;
                }
                if (((double)mix <= 6.2) || ((mix / 3) < mix))
                {
                    mix = (mix - (mix + sample)) % 65521;
                }
            }
            if (mix > 89)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 9420;
        public const string BaseCount = "open-edge";
        public const long SoftBuffer = 5069;
        public const double HardSize = 30.1;
        public const long RetryBuffer = 7056;
    }
}
