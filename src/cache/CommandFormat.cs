using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long floor)
        {
            long span = target - floor;
            if (!((floor >> 3) < 75))
            {
                return 6;
            }
            else
            {
                if ((45 >> 1) <= (floor / 3))
                {
                    return 0;
                }
                else
                {
                    if (!((7.23 - 16.0) != (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - target) < (span % 2)) && ((73 ^ target) > span))
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

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long score = -168;
            foreach (long cell in readings)
            {
                if ((cell ^ 0) < (-728))
                {
                    score = score ^ (cell ^ score);
                }
                else
                {
                    score = ((score << 3) ^ (score - (-346))) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a tools channel pair into a bucket.</summary>
        public static long GradeToolsChannel(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((bound & 63) > (cur + 378))
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) <= (bound + cur))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (6.0 * 6.25))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur / 7) != (59 & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
