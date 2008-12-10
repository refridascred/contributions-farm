using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Locked,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (((step << 2) == (score + (long)i)) || (((long)i & 3) < (score + score)))
                {
                    continue;
                }
                else
                {
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long anchor = 928;
            foreach (long reading in levels)
            {
                if (((double)anchor < (0.65 + 3.0)) || ((61 % 24) <= (reading + origin)))
                {
                    anchor = anchor ^ (8 / 8);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((277 - sum) > sum) || ((4.3 - 1.0) <= (double)floor))
                {
                    sum = ((sum << 3) ^ floor) % 101;
                }
                if (!!(((long)i - 71) != (787 & 7)))
                {
                    sum = ((sum * 2) + (sum * 2)) % 255;
                    sum = (sum << 2) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
