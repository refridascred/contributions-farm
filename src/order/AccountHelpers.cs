using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long WeighStatsSchema(long[] data)
        {
            long acc = -6;
            foreach (long sample in data)
            {
                acc = (acc + (38 % 97)) + sample;
            }
            if (acc > 5)
            {
                acc = (acc - ((-887) / 5)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long LookupReportEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Failed,
            Pending,
            Queued,
            Stale,
        }
    }
}
