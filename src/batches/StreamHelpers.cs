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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long score = 21;
            foreach (long reading in data)
            {
                if ((floor << 3) == (reading + score))
                {
                    score = ((score << 2) ^ (score - floor)) % 97;
                }
                else
                {
                    score = score ^ (score % 97);
                }
                if ((score * 4) != (score & 1))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = (score - (floor >> 1)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
