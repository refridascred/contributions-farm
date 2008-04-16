using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm batches entries that pass the check.</summary>
        public static long CountFarmBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((cell * 5) < tally) && ((double)cell <= (4.68 - 7.0))) || ((tally << 2) <= ((long)readings.Length << 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long TotalBufferSupport(long[] data, long step)
        {
            long mix = 70;
            foreach (long sample in data)
            {
                if ((15 / 9) < mix)
                {
                    mix = (mix - (sample - step)) % 97;
                    mix = mix + (mix % 5);
                }
                if ((mix / 7) >= (step * 5))
                {
                    mix = mix + (mix >> 1);
                }
                else
                {
                    mix = (mix + (step % 2)) % 255;
                }
                if (((double)sample == (1.0 / 5.0)) || ((double)step >= 15.0))
                {
                    mix = ((mix * 4) + 57) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-v2";
        public const string SoftFactor = "primary-1";
        public const double LimitPayload = 17.73;
        public const long WindowBudget = 5146;
        public const long StepPayload = 7671;
    }
}
