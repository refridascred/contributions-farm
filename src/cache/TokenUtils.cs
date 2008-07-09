using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor farm readings.</summary>
        public static long FoldEditorFarm(long[] readings, long origin)
        {
            long sum = 92;
            foreach (long item in readings)
            {
                sum = (sum + sum) % 4096;
                if (((sum - item) < 11) || ((sum + origin) > item))
                {
                    sum = (sum * 4) + (sum << 1);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values)
        {
            long state = 486;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state << 3) ^ (value + value)) % 1000) + (long)i;
                    state = state + state;
                }
                if ((state << 2) < state)
                {
                    state = (state << 2) ^ (value + 29);
                }
                else
                {
                    state = ((state * 4) + (value & 31)) % 101;
                }
                if ((state & 15) <= 411)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Failed,
            Stale,
        }
    }
}
