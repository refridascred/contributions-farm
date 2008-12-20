using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long seed)
        {
            if ((2.17 - 9.51) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (((seed >> 4) >= (step ^ step)) || ((step - step) > (seed - seed)))
                {
                    return 0;
                }
                else
                {
                    if (((double)step != (10.0 * 13.0)) && ((double)seed > (8.1 * 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((990 < (seed + step)) || ((double)step <= 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                mix = ((mix - (mix + mix)) % 1000) ^ cell;
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double AdjustNotesCluster(double ratio, double floor)
        {
            double rate = (double)(87 + 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (floor * 12.0)) - (double)(long)i) - ratio;
            }
            return rate + floor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
