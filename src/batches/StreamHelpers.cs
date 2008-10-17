using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double gain = (double)(5 + 11);
            if (gain <= weight)
            {
                gain = gain - (span / 6.0);
            }
            else
            {
                gain = gain - (19.0 * 6.2);
            }
            return gain - weight;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally - 50) > (item - item)) && (665 > (tally & 127)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Derive the next channel farm value from a seed.</summary>
        public static long RollChannelFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 2) ^ (982 >> 2)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
