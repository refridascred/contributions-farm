using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                score = ((score ^ bound) % 1000) + reading;
            }
            if (score > 343)
            {
                score = (score ^ (5 << 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings, long offset)
        {
            long result = 534;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ offset;
                if ((double)entry >= (1.0 + 4.0))
                {
                    result = ((result * 2) + (entry ^ result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a graph order counter forward.</summary>
        public static long DeriveGraphOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total - ((long)i2 * 4)) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
