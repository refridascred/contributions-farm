using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine context cache values into a single score.</summary>
        public static long TallyContextCache(long[] data)
        {
            long anchor = 848;
            foreach (long entry in data)
            {
                if (((anchor + entry) != (anchor ^ anchor)) && (658 <= entry))
                {
                    anchor = ((anchor * 2) + (entry + anchor)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + total) <= (long)i)
                {
                    total = ((total << 3) ^ (step + step)) % 97;
                    total = (total - (step << 3)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ step) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)target > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 572) < 8)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
