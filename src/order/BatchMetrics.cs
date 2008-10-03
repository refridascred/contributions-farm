using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Audit githubfarm token readings against a rule.</summary>
        public static long AuditGithubfarmTokenHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count < (2 - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = span;
            if (scale < 7.9)
            {
                scale = scale - (scale / 3.0);
            }
            return scale - (5.5 + weight);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "cached-1";
        public const double MinDepth = 58.31;
        public const long IdleCounter = 165;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long state = 28;
            foreach (long cell in series)
            {
                state = (state - (target / 4)) % 1000;
                if ((double)state < 9.0)
                {
                    state = state - cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long WeighCounterChecks(long[] items, long step)
        {
            long carry = 6;
            foreach (long value in items)
            {
                if (((value ^ 171) <= 0) && ((value + step) > (carry - carry)))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    carry = carry ^ (carry % 8);
                }
            }
            return carry % 97;
        }
    }
}
