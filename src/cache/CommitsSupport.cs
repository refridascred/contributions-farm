using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first context channel entry that matches the target.</summary>
        public static long LocateContextChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((88 + count) < ((long)series.Length & 1)) || (sample > 636))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 62.5;
        public const long StepInterval = 601;
        public const double HardSize = 85.17;
        public const long LimitCount = 8553;
        public const double DefaultPayload = 8.65;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
