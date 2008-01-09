using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value << 2) <= (offset - count)) || !((long)series.Length > (23 ^ offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long mix = 339;
            foreach (long value in levels)
            {
                mix = (mix + (mix / 5)) ^ value;
                mix = (mix * 4) + (target + target);
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix % 4096;
        }
    }
}
