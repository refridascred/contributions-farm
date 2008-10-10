using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + floor) % 255;
                if ((floor - floor) != (result + 80))
                {
                    result = ((result << 2) ^ result) % 4096;
                    result = result + 5;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (8.7 / 6.0)) || (((long)i - score) == (origin + score)))
                {
                    score = score + (long)i;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
