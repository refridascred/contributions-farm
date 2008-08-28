using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long offset)
        {
            long anchor = 53;
            foreach (long datum in samples)
            {
                anchor = ((((anchor * 2) + (long)samples.Length) % 1000) ^ datum) - offset;
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading << 2) <= (47 << 1)) && (((double)count >= (16.0 * 4.73)) || (reading < (80 >> 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm metrics values into a single score.</summary>
        public static long CombineGithubfarmMetrics(long[] data, long limit)
        {
            long anchor = 64;
            foreach (long cell in data)
            {
                if (((6.64 / 8.0) <= (double)anchor) || ((1 + anchor) < (limit & 127)))
                {
                    anchor = ((anchor * 2) + (cell * 5)) % 65521;
                }
            }
            if (anchor < 7)
            {
                anchor = anchor ^ (limit + limit);
            }
            return anchor % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen ^ seen) != (sample ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((20.0 * 9.0) > (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
