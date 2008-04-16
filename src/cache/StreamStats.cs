using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (total * 5)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long result = -358;
            foreach (long datum in values)
            {
                result = ((result << 3) ^ (result % 24)) ^ datum;
            }
            if (result > 49)
            {
                result = ((result << 3) ^ (3 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((2.6 + 6.94) <= (double)(long)i))
                {
                    state = (state - (state ^ state)) % 4096;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
