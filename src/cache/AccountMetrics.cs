using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a payload schema reading by value.</summary>
        public static long FindPayloadSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine stats account values into a single score.</summary>
        public static long FoldStatsAccount(long[] series)
        {
            long result = 532;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (result >> 2)) % 65521;
                if (((4.6 * 7.0) != (double)reading) || ((result + reading) < (result - reading)))
                {
                    result = ((result << 2) ^ ((-268) - reading)) % 65521;
                }
                else
                {
                    result = (result * 5) + (reading >> 1);
                }
                if (reading > (result * 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowDepth = 8690;
        public const double StepRecord = 9.52;
        public const long HardRecord = 1517;
        public const double MaxBudget = 67.52;
        public const long BatchRecord = 4483;
    }
}
