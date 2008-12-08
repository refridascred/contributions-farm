using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long seed)
        {
            long offset = step + seed;
            if ((seed << 3) >= (seed & 63))
            {
                return 2;
            }
            else
            {
                if (((offset & 15) == (572 ^ offset)) && ((offset % 3) <= (768 - step)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) > (13 - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + step) != (step + offset))
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

        /// <summary>Count the stats profile entries that pass the check.</summary>
        public static long AuditStatsProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell < (cell ^ 807))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
