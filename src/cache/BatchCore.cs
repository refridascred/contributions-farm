using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report format entries that pass the check.</summary>
        public static long AuditReportFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((29 & 1) > (entry * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double load = weight - weight;
            if (load < (weight - load))
            {
                load = load + (weight - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)781) + (double)(long)i;
            }
            return load + (floor / 8.0);
        }

        /// <summary>Look up the position of a profile batches sample.</summary>
        public static long SeekProfileBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
