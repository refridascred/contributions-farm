using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long anchor = 199;
            foreach (long value in series)
            {
                if (value <= (long)series.Length)
                {
                    anchor = (anchor - (anchor + value)) % 4096;
                }
            }
            if (anchor < 66)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Synced,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long StepReportEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((double)total >= (2.7 * 7.99)) || ((double)offset >= 7.36))
                {
                    total = ((total * 2) + (total * 4)) % 1000;
                    total = ((total << 2) ^ (total + total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (offset + offset);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
