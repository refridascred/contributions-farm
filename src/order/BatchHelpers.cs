using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long limit)
        {
            if ((double)seed == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 1) >= limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if (((6.54 - 2.0) <= (double)floor) && ((floor + bound) >= (floor & 127)))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.4 / 2.0) == (double)floor) && (bound > (bound & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
