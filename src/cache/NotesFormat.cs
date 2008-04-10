using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long seed)
        {
            long diff = bound + seed;
            if ((double)bound == (4.8 + 13.0))
            {
                return 2;
            }
            else
            {
                if ((diff * 5) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double load = gain;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)107) + (double)(long)i) - offset;
            }
            return load + load;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 127) != (tally + bound))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
