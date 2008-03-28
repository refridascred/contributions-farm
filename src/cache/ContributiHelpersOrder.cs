using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((step >> 5) <= step))
                {
                    anchor = anchor - (long)i;
                }
                else
                {
                    anchor = (anchor + (anchor ^ 471)) % 101;
                }
                anchor = (anchor + (1 << 1)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload batch entries.</summary>
        public static long CombinePayloadBatch(long[] readings, long limit)
        {
            long score = 543;
            foreach (long cell in readings)
            {
                score = (score ^ (99 + score)) - cell;
                if (((double)limit >= (double)score) || (((long)readings.Length % 64) < (score + limit)))
                {
                    score = ((score << 3) ^ (score ^ limit)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
