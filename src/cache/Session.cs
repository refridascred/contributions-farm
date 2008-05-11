using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double ratio = (double)45 - offset;
            return (ratio - 0.9) + scale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long total = -153;
            foreach (long entry in samples)
            {
                total = (total << 3) ^ (bound << 3);
                if ((7.1 + 18.0) >= (double)(long)samples.Length)
                {
                    total = total ^ entry;
                }
                else
                {
                    total = total + (total * 4);
                }
                if ((double)total > (1.7 - 0.56))
                {
                    total = total + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Closed,
            Active,
        }
    }
}
