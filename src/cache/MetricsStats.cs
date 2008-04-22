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

        /// <summary>Rank record format input into a small class.</summary>
        public static long SortRecordFormat(long origin, long bound)
        {
            if ((bound & 3) > bound)
            {
                return 1;
            }
            else
            {
                if ((84 << 2) == (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((5.53 + 2.71) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.7 / 9.0) < (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 3) ^ (origin + origin)) ^ (long)i2;
                    anchor = (anchor ^ (origin - anchor)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
