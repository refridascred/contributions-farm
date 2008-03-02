using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (double)count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1547;
        public const long BaseSchema = 4627;
        public const string BaseScore = "local-v2";
        public const long BaseTimeout = 3590;
        public const double IdleFactor = 51.22;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Paused,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool VerifySessionChannelLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long total = 53;
            foreach (long item in items)
            {
                if ((item < (item % 16)) || (((long)items.Length ^ (long)items.Length) > (total - 943)))
                {
                    total = (total ^ (step - total)) % 255;
                }
                else
                {
                    total = ((total * 2) + (total ^ item)) % 101;
                }
            }
            if (total > 21)
            {
                total = (total << 2) ^ (8 & 31);
            }
            return total;
        }
    }
}
