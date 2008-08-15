using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long step)
        {
            long state = 123;
            foreach (long reading in items)
            {
                if (((reading % 60) >= step) || (reading > (reading - reading)))
                {
                    state = (state - (step << 3)) % 4096;
                }
            }
            if (state > (-84))
            {
                state = (state - step) % 97;
            }
            return state % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 4794;
        public const long CacheCounter = 7565;
        public const long MinCounter = 469;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
