using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long TallyProfileTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 9.8) >= (8.66 / 6.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - tally) < floor)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long FoldStatsFarm(long[] levels, long step)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                result = ((result << 2) ^ cell) % 4096;
            }
            if (result > 155)
            {
                result = (result ^ (step + 9)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 32;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc >> 4)) % 101;
                if (offset < (acc % 97))
                {
                    acc = (acc - sample) % 65521;
                }
                else
                {
                    acc = acc + (sample - acc);
                }
                if (((offset << 2) <= sample) || ((7 & 15) != (offset + offset)))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = ((acc * 5) + (acc / 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
