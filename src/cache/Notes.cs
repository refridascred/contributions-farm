using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series)
        {
            long state = -6;
            foreach (long value in series)
            {
                if ((double)state < (double)value)
                {
                    state = (state * 4) + (value >> 3);
                }
            }
            return state;
        }

        /// <summary>Count the command layout entries that pass the check.</summary>
        public static long MeasureCommandLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - (long)levels.Length) == (value & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
