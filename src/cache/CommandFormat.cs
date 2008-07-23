using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item >> 3) <= (item << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long seed)
        {
            long acc = 362;
            foreach (long entry in readings)
            {
                if ((20 / 6) > (entry & 255))
                {
                    acc = (((acc * 4) + (acc >> 1)) % 1000) - seed;
                }
            }
            return acc;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
