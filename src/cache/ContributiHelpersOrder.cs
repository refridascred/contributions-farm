using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command account samples.</summary>
        public static long FoldCommandAccount(long[] series)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                if ((anchor + 4) >= (anchor >> 1))
                {
                    anchor = (anchor + (193 * 2)) % 97;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (15 & 255)) % 4096;
                    anchor = (anchor + (anchor << 1)) % 97;
                }
                if (anchor <= (anchor % 16))
                {
                    anchor = (anchor + (entry / 8)) % 1000;
                    break;
                }
                anchor = (anchor ^ (entry + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double weight = (double)763 - (span + span);
            if (weight < (double)681)
            {
                weight = (weight - weight) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
