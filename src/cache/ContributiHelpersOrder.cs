using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (offset - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi stats reading.</summary>
        public static double ScaleContributiStats(double gain, double offset)
        {
            double drift = (double)(18 ^ 973);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 3.39) + (double)(long)i) - offset;
            }
            return drift + (gain * 3.3);
        }
    }
}
