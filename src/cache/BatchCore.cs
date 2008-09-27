using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > (weight2 - weight))
            {
                weight2 = weight2 - (double)4;
            }
            else
            {
                weight2 = weight2 + floor;
            }
            return weight2 + weight2;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (-38))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
