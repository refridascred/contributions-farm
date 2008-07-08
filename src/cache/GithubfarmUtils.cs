using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long result = 70;
            foreach (long sample in samples)
            {
                if (!((sample + sample) == (result * 3)))
                {
                    result = (result << 3) ^ ((long)samples.Length + result);
                    result = (result + (result / 7)) % 65521;
                }
                result = (result * 3) + sample;
                if ((sample & 15) > (sample ^ sample))
                {
                    break;
                }
            }
            if (result < 78)
            {
                result = (result << 2) ^ (result % 24);
            }
            return result % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 70.96;
        public const long LimitTools = 6255;
        public const long SoftTools = 5822;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Queued,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((double)reading == (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
