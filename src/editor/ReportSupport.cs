using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const long BatchLevel = 1429;
        public const long WindowSession = 7497;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >> 4) != (value - (-39))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ target) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many token queue samples are out of range.</summary>
        public static long CountTokenQueueOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item << 3) >= (532 ^ floor))
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
    }
}
