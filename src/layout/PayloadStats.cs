using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            if (offset > 861)
            {
                return 5;
            }
            else
            {
                if (6.3 <= (2.8 - 2.6))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) <= (floor + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((417 ^ floor) > (floor + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
