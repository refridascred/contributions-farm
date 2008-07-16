using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long anchor = -202;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    anchor = anchor - (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double gain2 = (gain / 6.0) - (double)355;
            if (gain2 > (8.4 * 9.0))
            {
                gain2 = gain2 - (double)679;
            }
            else
            {
                gain2 = gain2 + (span - span);
            }
            return gain2 - (gain2 + 4.82);
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
