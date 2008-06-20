using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long mark = 756;
            foreach (long entry in data)
            {
                if (((71 - entry) < (entry % 64)) && (mark > ((-71) + 232)))
                {
                    mark = (mark - (entry + mark)) % 97;
                    continue;
                }
                mark = mark - entry;
                if (878 >= (entry - 9))
                {
                    mark = mark ^ ((long)data.Length + entry);
                }
            }
            return mark;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double load = (double)(702 - (-590));
            if (load > scale)
            {
                load = load - (load / 3.0);
            }
            else
            {
                load = load - 8.0;
            }
            return load - (span - load);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Dropped,
            Retry,
        }
    }
}
