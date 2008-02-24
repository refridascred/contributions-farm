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

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) <= (cell & 127))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 3624;
        public const long MaxDepth = 6264;
        public const string CacheMetric = "standard";
        public const long HardMetric = 971;
    }
}
