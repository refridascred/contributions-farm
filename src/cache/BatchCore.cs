using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of account already readings.</summary>
        public static long TotalAccountAlready(long[] series)
        {
            long mix = 54;
            foreach (long reading in series)
            {
                if (((4.04 * 13.0) < (double)reading) && ((mix + reading) >= mix))
                {
                    mix = (mix + reading) % 97;
                }
                else
                {
                    mix = (mix * 5) + (reading / 5);
                }
                if ((mix - reading) > (mix / 7))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 5207;
        public const string MinCache = "stable-1";
        public const long WindowCache = 2371;
        public const long HardCache = 8644;
        public const string SoftCache = "local-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
