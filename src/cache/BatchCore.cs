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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] samples, long limit)
        {
            long state = 824;
            foreach (long datum in samples)
            {
                state = ((state - (limit / 3)) % 1000) ^ datum;
                state = (state - (limit & 7)) % 97;
            }
            return state;
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
