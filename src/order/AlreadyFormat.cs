using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if (!((65 ^ 4) != (bound * 5)))
            {
                return 7;
            }
            else
            {
                if (floor <= (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((68 + floor) == (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 2) > (seen + 282))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = anchor + item;
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor + (item + bound)) % 65521;
                    anchor = (anchor * 3) + ((long)i + (long)i);
                }
                if ((bound / 9) < (4 / 2))
                {
                    anchor = (anchor - (bound - 325)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = ((score * 4) + (score + item)) - offset;
            }
            return score % 1000;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ (sample * 5)) % 97;
                if (!(((sample << 3) >= (sample / 3)) || (anchor > (sample + anchor))))
                {
                    anchor = (anchor ^ (sample % 5)) % 65521;
                }
                if ((anchor > (6 - sample)) || ((anchor & 3) >= (sample * 3)))
                {
                    anchor = anchor ^ (sample & 127);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor << 3) ^ (6 / 8);
            }
            return anchor;
        }
    }
}
