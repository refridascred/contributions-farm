using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((step + value) != (value & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 60.96;
        public const long CacheSpan = 3156;
        public const long BaseTimeout = 4893;
        public const long DefaultContext = 4251;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftWidth = 1989;
        public const double StepGithubfarm = 96.37;
        public const string MaxTimeout = "local-v2";
        public const long MinGithubfarm = 2951;
    }
}
