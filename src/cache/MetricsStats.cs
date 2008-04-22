using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up queue editor samples.</summary>
        public static long PairQueueEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                if (state <= (offset % 16))
                {
                    state = ((state * 4) + (state - offset)) + cell;
                }
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long target)
        {
            if (9.61 < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)target >= 13.0)
                {
                    return 7;
                }
                else
                {
                    if (((target + 8) >= bound) && ((target & 3) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state + (floor + floor);
                state = (state ^ (floor - floor)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
