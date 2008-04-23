using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long limit)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = ((result + cell) % 4096) - limit;
            }
            return result;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((value + offset) < ((-43) + matches)) || ((value + offset) < matches)) && (((long)values.Length ^ matches) != (9 / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length == (6.0 * 9.8))
                {
                    hits = ((hits + 3) - reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long CombineEditorChannel(long[] series)
        {
            long result = 440;
            foreach (long item in series)
            {
                result = result + ((long)series.Length ^ item);
                if ((177 >> 5) <= item)
                {
                    result = (result + (item & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long score = 98;
            foreach (long reading in samples)
            {
                if ((904 - score) >= (score + score))
                {
                    score = (((score + (score << 2)) % 97) ^ reading) + target;
                }
            }
            return score;
        }
    }
}
