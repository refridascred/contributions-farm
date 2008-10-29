using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + ((long)i << 1)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long DigestChannelSupport(long[] levels, long step)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix << 3) ^ (mix + 69)) % 255) + (long)i;
                    mix = (mix - (836 - mix)) % 255;
                }
                if ((double)reading != (9.76 + 2.29))
                {
                    mix = (mix - reading) % 1000;
                    mix = (mix ^ (reading + reading)) % 255;
                }
                if ((reading % 5) <= step)
                {
                    mix = mix ^ (reading * 5);
                }
                else
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Pending,
            Retry,
            Idle,
            New,
        }
    }
}
