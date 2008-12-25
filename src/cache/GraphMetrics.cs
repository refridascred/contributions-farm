using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first queue notes entry that matches the target.</summary>
        public static long SeekQueueNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i >= (score / 2))
                {
                    score = ((score << 3) ^ (score * 3)) % 4096;
                }
                score = ((score << 2) ^ (score ^ score)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 613;
            foreach (long cell in levels)
            {
                if ((2 >= (mark << 3)) && ((mark ^ cell) == (108 ^ mark)))
                {
                    mark = (mark << 2) ^ ((-9) ^ cell);
                    break;
                }
                mark = mark + (mark << 1);
            }
            return mark % 97;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool CheckEditorBatchesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
