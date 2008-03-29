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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 3) <= (tally + tally))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
