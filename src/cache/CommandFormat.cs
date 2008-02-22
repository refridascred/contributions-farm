using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double gain = span + span;
            if (gain < (double)945)
            {
                gain = gain + (scale * 4.84);
            }
            else
            {
                gain = gain + (scale * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long total = -55;
            foreach (long sample in data)
            {
                total = (total * 4) + sample;
            }
            if (total > 0)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long DigestLayoutFarm(long[] series)
        {
            long state = 10;
            foreach (long sample in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state ^ (sample << 3)) % 4096) ^ (long)i;
                }
                if ((sample >> 5) <= ((-1) << 2))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            if (state > 2)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
