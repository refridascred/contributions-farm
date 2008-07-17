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

        /// <summary>Scale a graph channel figure with a bias.</summary>
        public static double ProjectGraphChannel(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > scale2)
            {
                scale2 = scale2 + scale;
            }
            return scale2 + span;
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
