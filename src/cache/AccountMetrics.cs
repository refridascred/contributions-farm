using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long bound)
        {
            long span = target - bound;
            if ((span ^ bound) == (span >> 1))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) == (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if ((entry + (-924)) == (total - total))
                {
                    total = ((total << 3) ^ (total << 2)) % 65521;
                }
                if ((double)total > (3.45 + 1.08))
                {
                    total = ((total * 4) + total) % 65521;
                    total = (total + (entry & 1)) % 101;
                }
                if (total > (3 + total))
                {
                    total = total + (entry * 3);
                }
                if (((long)levels.Length & 127) != (entry ^ entry))
                {
                    break;
                }
            }
            if (total > 994)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 95;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample < (total >> 1)) || ((sample + sample) != (total << 3)))
                {
                    total = ((total * 3) + (sample - total)) % 255;
                }
                if (((16.0 + 12.0) >= (double)total) && ((sample << 3) >= (sample + total)))
                {
                    total = (total - total) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "cached";
        public const long LimitNotes = 3397;
        public const string SoftSpan = "local";
        public const long IdleNotes = 2305;
        public const double BurstFactor = 17.34;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
