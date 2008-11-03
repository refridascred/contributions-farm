using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream graph value from a seed.</summary>
        public static long IterateStreamGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((state ^ state) > (long)i)
                {
                    state = state - ((long)i & 31);
                    state = state + origin;
                }
                state = state + ((long)i + origin);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((33 + (long)data.Length) >= (entry * 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
