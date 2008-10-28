using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "local-edge";
        public const long LimitFactor = 588;
        public const long WindowBatches = 693;

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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
