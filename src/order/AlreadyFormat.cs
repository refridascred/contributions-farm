using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank tools cluster input into a small class.</summary>
        public static long ClassifyToolsCluster(long target, long floor)
        {
            long lane = target - floor;
            if ((double)target >= (3.6 * 3.21))
            {
                return 3;
            }
            else
            {
                if (floor <= ((-62) % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)lane > 9.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane < (lane << 1)) || ((lane ^ floor) < (target - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((7.3 / 5.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)offset != (1.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) < (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools profile value from a seed.</summary>
        public static long SeriesToolsProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                long matches = floor;
                score = (score ^ (score / 8)) % 1000;
                score = (score * 3) + matches;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ total;
                total = (total - (long)i) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
