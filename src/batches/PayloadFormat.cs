using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if ((offset2 + offset2) > (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (2.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((373 - offset) > (offset2 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > (6.9 - 12.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(bound >= (tally / 9)) && ((item >> 2) < bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
