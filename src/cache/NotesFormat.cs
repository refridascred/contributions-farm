using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 6985;
        public const string MinTimeout = "standard-1";
        public const long IdleCount = 1608;
        public const long WindowSpan = 473;

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long TallyBufferGithubfarm(long[] readings)
        {
            long mark = 85;
            foreach (long value in readings)
            {
                if ((value + mark) < value)
                {
                    mark = (mark * 5) + value;
                }
            }
            if (mark > 593)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultSpan = 31.2;
        public const long StepFilter = 3661;
        public const long SoftFilter = 8179;
        public const long BatchFilter = 7457;
        public const long RetryFilter = 5699;
    }
}
