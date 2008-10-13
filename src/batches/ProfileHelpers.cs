using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long anchor = 0;
            foreach (long entry in data)
            {
                anchor = anchor ^ (anchor - entry);
                anchor = (anchor + (entry << 2)) % 65521;
                anchor = ((anchor * 4) + 956) % 4096;
            }
            if (anchor < (-49))
            {
                anchor = (anchor - (anchor / 2)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.5 - 4.3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 2314;
        public const long LimitTimeout = 444;
        public const long DefaultBudget = 6913;
        public const double MinEditor = 92.84;
        public const long BatchEditor = 6966;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin + seen) < origin)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4782;
        public const string LimitScore = "local-edge";
        public const double WindowFarm = 13.82;
        public const long MaxRatio = 6498;
        public const double IdleFarm = 36.25;
    }
}
