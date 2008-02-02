using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (7 <= matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
