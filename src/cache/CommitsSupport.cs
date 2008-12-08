using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell <= (cell / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples)
        {
            long mix = 924;
            foreach (long cell in samples)
            {
                if ((mix / 9) >= (cell + cell))
                {
                    mix = (mix + cell) % 65521;
                }
                else
                {
                    mix = (mix + (cell >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long floor)
        {
            long offset = target - floor;
            if (((38 + floor) >= (offset ^ floor)) || ((double)offset < (double)873))
            {
                return 0;
            }
            else
            {
                if ((floor + offset) < floor)
                {
                    return 7;
                }
                else
                {
                    if (7 <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset >= (450 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
