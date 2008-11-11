using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length == (double)1)
                {
                    hits = ((hits + 2) - value) - floor;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 3751;
        public const long CacheTimeout = 1374;
        public const string DefaultEntry = "staging-1";
        public const long HardLevel = 7520;
        public const string IdleEntry = "local-edge";

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
