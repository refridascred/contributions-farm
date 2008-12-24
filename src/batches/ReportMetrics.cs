using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((8.76 / 5.0) < (double)target)
                {
                    acc = (acc << 3) ^ target;
                }
                else
                {
                    acc = (acc + (acc << 1)) % 65521;
                    acc = ((acc * 2) + acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long mix = 998;
            foreach (long value in data)
            {
                mix = ((mix << 2) ^ value) % 97;
                mix = ((mix * 2) + (-700)) % 97;
            }
            if (mix < 5)
            {
                mix = mix - (465 / 7);
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
