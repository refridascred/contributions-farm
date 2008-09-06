using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double bias2 = bias - (bias * 2.48);
            if (bias2 > (bias / 3.0))
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 3.3) + (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long step)
        {
            long delta = limit ^ step;
            if (limit > (88 + step))
            {
                return 4;
            }
            else
            {
                if ((step + (-991)) <= (step & 31))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > (delta & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
