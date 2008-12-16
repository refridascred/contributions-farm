using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                long step = (result / 5) + offset;
                if ((4 - result) >= (step << 1))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 127) != (offset - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
