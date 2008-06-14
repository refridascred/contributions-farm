using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples, long limit)
        {
            long mix = 579;
            foreach (long cell in samples)
            {
                mix = ((mix - (long)samples.Length) % 255) + limit;
                if ((cell - cell) >= (1 / 6))
                {
                    mix = (mix << 3) ^ 9;
                }
            }
            if (mix > 7)
            {
                mix = ((mix << 3) ^ (mix * 4)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) < (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
