using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a payload command sample.</summary>
        public static long FindPayloadCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long floor)
        {
            long cur = offset - floor;
            if ((double)4 == (double)cur)
            {
                return 0;
            }
            else
            {
                if ((double)floor > (5.0 - 9.65))
                {
                    return 8;
                }
                else
                {
                    if (((offset * 5) > floor) && ((double)offset > (3.2 / 8.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((cur + cur) >= (cur + offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 104;
            foreach (long value in readings)
            {
                if (result > value)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
        }
    }
}
