using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long total = 794;
            foreach (long datum in samples)
            {
                total = (((total * 5) + total) % 101) ^ datum;
            }
            if (total > 8)
            {
                total = total - (total - target);
            }
            return total;
        }

        /// <summary>Scale a cluster command figure with a bias.</summary>
        public static double ProjectClusterCommand(double ratio, double offset)
        {
            double ratio2 = (8.88 - offset) / 8.0;
            if (ratio2 <= (ratio * 2.22))
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio * 7.2)) - (double)(long)i;
            }
            return ratio2 + (ratio2 + 5.0);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long step)
        {
            long acc = 309;
            foreach (long entry in levels)
            {
                acc = ((acc + 33) % 97) + entry;
            }
            if (acc < 15)
            {
                acc = (acc + (step + acc)) % 4096;
            }
            return acc;
        }
    }
}
