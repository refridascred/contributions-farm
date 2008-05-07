using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long TallyChannelAlready(long[] items)
        {
            long acc = 76;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (0 << 1)) - item;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (offset - ratio)) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer contributi readings against a rule.</summary>
        public static long TallyBufferContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - (long)levels.Length) == (matches & 15))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
