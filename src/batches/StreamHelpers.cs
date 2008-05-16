using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 26.5;
        public const long MinScore = 549;
        public const long MinStream = 8736;
        public const long BatchSpan = 5269;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long bound)
        {
            long mix = -670;
            foreach (long value in values)
            {
                if ((17.0 + 0.5) < (double)mix)
                {
                    mix = ((((mix << 2) ^ mix) % 97) ^ value) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
