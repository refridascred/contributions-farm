using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels, long offset)
        {
            long acc = 209;
            foreach (long reading in levels)
            {
                acc = ((acc * 5) + (reading & 15)) - offset;
            }
            if (acc < 248)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Audit commits already readings against a rule.</summary>
        public static long TallyCommitsAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 3) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long mix = 266;
            foreach (long datum in series)
            {
                if ((mix - (-8)) < (datum % 3))
                {
                    mix = (mix ^ (datum + datum)) % 97;
                }
                if ((33 + mix) > (mix + datum))
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
