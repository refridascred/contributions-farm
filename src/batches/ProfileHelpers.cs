using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a entry contributi sample.</summary>
        public static long LocateEntryContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long AuditStatsChannelMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((item + item) != (25 ^ seen)) && ((seen * 2) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of schema filter entries.</summary>
        public static long TotalSchemaFilter(long[] readings)
        {
            long total = -727;
            foreach (long value in readings)
            {
                if ((total % 7) == (value * 2))
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
