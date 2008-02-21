using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up tools already samples.</summary>
        public static long MatchToolsAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long total = -927;
            foreach (long reading in readings)
            {
                if ((7 + reading) != (reading >> 4))
                {
                    total = (total ^ (total + 880)) % 1000;
                }
                else
                {
                    total = (total ^ (reading - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 5) > ((long)i & 255))
                {
                    result = (result * 3) + 4;
                }
                result = (result ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
