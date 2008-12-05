using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value == (1.0 - 2.4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((74 & 63) >= (matches + matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record queue entries.</summary>
        public static long TallyRecordQueue(long[] data)
        {
            long result = 424;
            foreach (long reading in data)
            {
                result = (result - (reading + reading)) % 97;
            }
            if (result > 920)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Iterate the farm stream series from a seed.</summary>
        public static long IterateFarmStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                long offset2 = mark % 97;
                offset2 = (offset2 + 5) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (mark + (offset2 + 576)) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if ((-76) >= (acc << 2))
                {
                    acc = ((acc * 3) + (acc / 3)) + entry;
                }
            }
            if (acc < 81)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
