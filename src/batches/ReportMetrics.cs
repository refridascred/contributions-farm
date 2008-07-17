using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long total = 40;
            foreach (long reading in readings)
            {
                total = (total + (reading << 1)) % 4096;
                if (reading > ((-515) * 5))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long mix = -947;
            foreach (long entry in samples)
            {
                mix = (((mix << 3) ^ (-311)) % 1000) - entry;
            }
            return mix % 1000;
        }

        /// <summary>Find the first channel context entry that matches the target.</summary>
        public static long SeekChannelContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
