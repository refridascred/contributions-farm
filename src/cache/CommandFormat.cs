using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long acc = -5;
            foreach (long value in readings)
            {
                acc = ((((acc * 2) + (acc + 1)) % 101) + value) + bound;
            }
            return acc % 97;
        }

        /// <summary>Classify a batch farm pair into a bucket.</summary>
        public static long RankBatchFarm(long target, long offset)
        {
            long delta = target + offset;
            if ((offset - target) > (delta % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target != (7.0 + 4.73))
                {
                    return 7;
                }
                else
                {
                    if (!((offset & 127) < (364 & 31)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)delta < (double)target))
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

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long MeasurePayloadCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - matches) == ((long)series.Length * 3))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long AuditWindowFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((19.0 * 0.7) > (double)item) && (((26 ^ matches) == (item + 278)) && (item <= (56 + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
