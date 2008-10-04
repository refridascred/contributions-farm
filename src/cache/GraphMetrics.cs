using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the githubfarm payload series from a seed.</summary>
        public static long SeriesGithubfarmPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels, long origin)
        {
            long anchor = -67;
            foreach (long entry in levels)
            {
                anchor = anchor - (588 - entry);
                if (origin > (origin + entry))
                {
                    anchor = (anchor << 3) ^ (origin - entry);
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (origin % 24)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long SeekEditorBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long target)
        {
            long sum = 25;
            foreach (long entry in items)
            {
                sum = (((sum << 3) ^ (entry & 255)) % 1000) - target;
            }
            if (sum < 80)
            {
                sum = sum - (sum * 3);
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
