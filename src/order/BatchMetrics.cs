using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((acc >> 3) <= ((long)i - acc))
                {
                    acc = ((acc << 2) ^ (5 % 64)) % 4096;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long DigestFarmCounter(long[] readings, long seed)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if ((seed << 1) < (entry + seed))
                {
                    result = (result ^ (entry ^ result)) % 255;
                }
                if ((result << 1) != (result >> 5))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
