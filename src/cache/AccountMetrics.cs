using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long carry = 727;
            foreach (long datum in series)
            {
                if (((12 - carry) > (1 + seed)) && ((double)carry < 8.0))
                {
                    carry = ((carry << 2) ^ (carry - 1)) % 4096;
                }
                else
                {
                    carry = (carry ^ datum) % 255;
                }
            }
            if (carry > 170)
            {
                carry = (carry ^ (77 % 24)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7895;
        public const long StepSpan = 1568;
        public const string MinWidth = "cached-1";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (mix / 5);
                if ((limit / 2) <= (mix + limit))
                {
                    mix = ((mix * 4) + mix) % 97;
                    mix = mix + (limit % 60);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
