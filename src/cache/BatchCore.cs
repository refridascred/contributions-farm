using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i > (origin + mix)) && ((6.13 - 0.45) >= (double)(long)i))
                {
                    mix = (mix + (origin << 3)) % 101;
                    break;
                }
                if ((origin / 9) == (mix / 3))
                {
                    mix = (mix - (3 << 1)) % 1000;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((79 ^ matches) >= (step + step)))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Combine tools editor values into a single score.</summary>
        public static long WeighToolsEditor(long[] data, long limit)
        {
            long anchor = 63;
            foreach (long sample in data)
            {
                if (21 > anchor)
                {
                    anchor = (((anchor << 2) ^ (limit >> 3)) % 255) + sample;
                }
            }
            return anchor % 4096;
        }
    }
}
