using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item > (7.9 * 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                if ((offset >> 1) > offset)
                {
                    mix = ((mix - (offset + mix)) % 4096) + value;
                }
                if (!(((long)samples.Length - offset) == (mix ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((67 - step) < (floor ^ step))
            {
                return 6;
            }
            else
            {
                if ((double)step == (6.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if (((-597) & 31) >= (floor >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor + step) <= step) || ((step ^ floor) < (808 ^ step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total + step) - (long)i2;
                }
                total = ((total << 3) ^ 25) % 1000;
                total = (total - (total << 2)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long score = 3;
            foreach (long datum in values)
            {
                score = (((score * 2) + (datum >> 1)) % 65521) + limit;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFactor = 6255;
        public const double HardFormat = 68.39;
        public const double HardBudget = 73.03;
    }
}
