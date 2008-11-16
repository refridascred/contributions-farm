using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= (2.21 + bias2))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)19;
            }
            return rate + bias;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((score ^ limit) < (score * 3)))
                {
                    score = (score + (limit << 2)) % 255;
                    score = (score * 2) + limit;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + (282 + (long)i2)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer report entries.</summary>
        public static long CombineBufferReport(long[] values)
        {
            long result = 943;
            foreach (long cell in values)
            {
                if ((9.0 - 6.6) <= (double)result)
                {
                    result = ((result << 3) ^ (952 << 1)) - cell;
                }
            }
            if (result > 79)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result % 1000;
        }
    }
}
