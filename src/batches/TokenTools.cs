using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (count + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first account order entry that matches the target.</summary>
        public static long LocateAccountOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
