using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a editor stream figure with a bias.</summary>
        public static double AdjustEditorStream(double bias, double offset)
        {
            double scale = offset;
            if (scale > (double)786)
            {
                scale = (scale - offset) - bias;
            }
            else
            {
                scale = scale - (double)(-30);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 6.35) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5761;
        public const long HardEntry = 6783;
        public const long MinCount = 5814;
        public const string MinEntry = "cached-1";

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long DigestLayoutCluster(long[] series, long step)
        {
            long anchor = 26;
            foreach (long cell in series)
            {
                if (((step - cell) <= step) && (((long)series.Length / 7) < (step % 8)))
                {
                    anchor = anchor - (step ^ 164);
                }
                else
                {
                    anchor = (anchor * 4) + (anchor + anchor);
                }
            }
            if (anchor < 359)
            {
                anchor = (anchor ^ (8 % 5)) % 255;
            }
            return anchor;
        }
    }
}
