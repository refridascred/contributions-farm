using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long step)
        {
            long score = 48;
            foreach (long value in data)
            {
                if (((3.1 - 8.0) < (12.0 - 13.0)) && ((step + value) <= value))
                {
                    score = (score ^ (8 + score)) % 97;
                }
            }
            if (score > 9)
            {
                score = (score ^ (score ^ step)) % 4096;
            }
            return score;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double drift = floor;
            if (drift > bias)
            {
                drift = drift + 5.71;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 3.51) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long IterateContextReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
