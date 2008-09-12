using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((origin / 9) >= (total + origin)))
                {
                    total = ((total * 4) + (origin & 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count metric route pairs that satisfy a relation.</summary>
        public static long CompareMetricRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ count) >= (count + datum))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
