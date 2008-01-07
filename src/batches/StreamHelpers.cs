using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFactor = 77.95;
        public const string WindowSpan = "standard-v2";
        public const long BaseLevel = 1286;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long LookupEntryGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Draft,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 971;
            foreach (long cell in values)
            {
                if ((cell - mark) >= (cell + cell))
                {
                    mark = (mark + (mark >> 5)) % 65521;
                }
            }
            return mark;
        }
    }
}
