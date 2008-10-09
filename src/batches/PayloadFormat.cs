using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long target)
        {
            long mark = 64;
            foreach (long entry in values)
            {
                mark = ((mark + (entry ^ mark)) % 4096) - target;
            }
            return mark % 4096;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long limit)
        {
            long sum = 443;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry & 15)) % 101;
                if ((limit & 127) < (entry + entry))
                {
                    sum = (sum + (sum - limit)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
