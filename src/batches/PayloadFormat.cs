using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of graph layout readings.</summary>
        public static long ScoreGraphLayout(long[] data, long origin)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (((score & 31) >= (origin << 3)) || ((item % 5) < (score - score)))
                {
                    score = score ^ score;
                }
                if ((score >> 1) <= ((long)data.Length & 3))
                {
                    break;
                }
            }
            if (score > 1)
            {
                score = (score * 5) + (-64);
            }
            return score;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload buffer reading.</summary>
        public static double SmoothPayloadBuffer(double rate, double floor)
        {
            double gain = 8.0 - (floor - 2.0);
            if (gain > (floor / 7.0))
            {
                gain = gain - floor;
            }
            return gain + rate;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
