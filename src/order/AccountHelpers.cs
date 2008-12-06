using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record queue entries.</summary>
        public static long TallyRecordQueue(long[] data)
        {
            long result = 424;
            foreach (long reading in data)
            {
                result = (result - (reading + reading)) % 97;
            }
            if (result > 920)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinCount = 6895;
        public const long BatchChecks = 2163;
        public const string HardWidth = "open-1";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > sample) || ((156 << 3) > (sample - (-5))))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Done,
            Synced,
            Retry,
        }
    }
}
