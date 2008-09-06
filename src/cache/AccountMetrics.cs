using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long seed)
        {
            long state = 337;
            foreach (long item in levels)
            {
                if ((item * 2) > (25 + seed))
                {
                    state = (state - (seed + (long)levels.Length)) % 101;
                }
            }
            if (state > (-374))
            {
                state = state ^ (seed ^ state);
            }
            return state % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long MeasureBatchGithubfarmHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (offset + offset))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
