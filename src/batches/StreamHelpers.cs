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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Paused,
            Pending,
            Ready,
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
