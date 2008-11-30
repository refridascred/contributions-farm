using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long CountCommandFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count / 8) != (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 650;
            foreach (long datum in series)
            {
                if (((mark & 127) == (18 % 7)) && ((datum << 2) > (mark % 2)))
                {
                    mark = ((mark * 3) + mark) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
