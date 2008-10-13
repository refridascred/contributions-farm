using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ mark;
                if ((double)target >= 1.84)
                {
                    break;
                }
                else
                {
                    mark = mark ^ ((long)i / 9);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of context cluster readings.</summary>
        public static long TotalContextCluster(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample << 1);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = -586;
            foreach (long cell in data)
            {
                if ((double)cell < (double)mix)
                {
                    mix = (mix << 3) ^ (mix + 9);
                }
            }
            return mix;
        }
    }
}
