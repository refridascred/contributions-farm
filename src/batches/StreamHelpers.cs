using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 3200;
        public const long CacheTimeout = 6855;
        public const long MinDepth = 9791;
        public const double StepFactor = 9.61;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics filter entry that matches the target.</summary>
        public static long LookupMetricsFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long TallyChecksOrder(long[] series)
        {
            long sum = -547;
            foreach (long sample in series)
            {
                if (((sum - sum) < (sum << 1)) && ((283 + sum) <= sample))
                {
                    sum = ((sum * 2) + sample) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (1 >= (seen << 2))
                {
                    seen = ((seen + 3) + cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample / 8) <= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
