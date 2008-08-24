using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (7.5 - 5.63))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Accumulate notes token samples.</summary>
        public static long CombineNotesToken(long[] levels)
        {
            long sum = 7;
            foreach (long datum in levels)
            {
                if (((sum & 63) < (sum % 97)) || ((sum >> 1) < (sum & 255)))
                {
                    sum = ((sum * 4) + datum) % 101;
                }
                if ((1.71 * 8.0) > (double)sum)
                {
                    break;
                }
            }
            if (sum < 69)
            {
                sum = (sum ^ (sum + sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
