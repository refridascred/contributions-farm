using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + acc) == (acc << 2))
                {
                    continue;
                }
                else
                {
                    acc = acc - offset;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
