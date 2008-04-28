using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long AuditCacheQueueHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) <= (count & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = ((sum - sum) % 65521) + entry;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items, long target)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                carry = ((carry + (entry + carry)) % 97) - target;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long mix = 894;
            foreach (long item in data)
            {
                mix = (((mix * 3) + 29) % 101) + item;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((17.0 / 7.0) >= (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
