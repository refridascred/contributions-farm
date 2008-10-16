using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + 988) % 65521;
                carry = (carry + bound) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long floor)
        {
            if ((limit <= (floor & 1)) || (floor >= (limit & 63)))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 7.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                if ((9.98 + 9.58) != (double)value)
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 840;
            foreach (long item in data)
            {
                result = (result ^ (result + item)) % 255;
            }
            if (result > (-491))
            {
                result = result + result;
            }
            return result % 4096;
        }
    }
}
