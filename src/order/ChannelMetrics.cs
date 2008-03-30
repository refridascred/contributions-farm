using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream batches entries.</summary>
        public static long FoldStreamBatches(long[] values)
        {
            long score = 58;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ ((-9) + 149)) % 97;
                if (sample > (77 - (long)values.Length))
                {
                    score = ((score << 3) ^ (score ^ score)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
