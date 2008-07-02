using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
