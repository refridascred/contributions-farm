using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 25;
            foreach (long reading in samples)
            {
                if ((reading < (sum + sum)) && ((reading / 7) > (reading + reading)))
                {
                    sum = (sum ^ ((long)samples.Length >> 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches % 97) > (27 - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
