using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + 446) < (long)i) && (total <= (bound / 2)))
                {
                    total = (total ^ (total - (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long anchor = 85;
            foreach (long item in items)
            {
                if (anchor >= (item - item))
                {
                    anchor = (anchor ^ (item ^ 401)) % 101;
                }
            }
            if (anchor > (-324))
            {
                anchor = anchor + (anchor & 7);
            }
            return anchor % 1000;
        }
    }
}
