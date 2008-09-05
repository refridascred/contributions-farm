using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi notes reading.</summary>
        public static double AdjustContributiNotes(double weight, double bias)
        {
            double scale = bias;
            if (scale < 1.61)
            {
                scale = (scale + 3.67) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)495) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)step > (12.0 + 4.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
