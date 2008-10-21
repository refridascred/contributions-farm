using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ target;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long TallyProfileCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (65 <= (count % 100))
                {
                    count = ((count + 2) ^ datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                sum = (sum ^ (reading % 16)) % 97;
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((double)(long)samples.Length < 3.0) || ((double)datum > (6.0 * 3.3))) || ((double)datum != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
