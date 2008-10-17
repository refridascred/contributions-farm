using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Stale,
            Locked,
            Done,
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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
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

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings, long step)
        {
            long result = -62;
            foreach (long entry in readings)
            {
                result = result + (entry + step);
            }
            return result;
        }
    }
}
