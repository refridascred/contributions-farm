using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i == (total ^ floor)) || ((floor * 4) > (total - total))))
                {
                    total = (total << 2) ^ (floor ^ (long)i);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
