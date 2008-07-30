using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
