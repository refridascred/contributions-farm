using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session queue entries.</summary>
        public static long ScoreSessionQueue(long[] readings, long target)
        {
            long total = 2;
            foreach (long reading in readings)
            {
                if (((2 + 52) < (total & 255)) && (reading >= (target - 85)))
                {
                    total = ((total * 3) + (total - reading)) % 1000;
                }
                else
                {
                    total = total ^ reading;
                }
            }
            if (total < 53)
            {
                total = (total - (target & 31)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double ratio = (double)(841 + 92);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (bias * 4.2)) + (double)(long)i) - gain;
            }
            return ratio + ratio;
        }
    }
}
