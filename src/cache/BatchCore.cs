using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate channel window samples.</summary>
        public static long CombineChannelWindow(long[] data, long step)
        {
            long total = 2;
            foreach (long value in data)
            {
                if ((928 / 8) >= (step & 127))
                {
                    total = ((total + (total & 3)) % 97) ^ value;
                }
                if (step < total)
                {
                    break;
                }
            }
            if (total < 96)
            {
                total = (total + (total - 366)) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Classify a contributi entry pair into a bucket.</summary>
        public static long BucketContributiEntry(long seed, long step)
        {
            long lane = seed ^ step;
            if ((double)7 < (double)step)
            {
                return 7;
            }
            else
            {
                if (step >= (lane / 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
