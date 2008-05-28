using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double load = weight;
            if (load > weight)
            {
                load = (load + weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (8.0 / 3.0)) + (double)(long)i;
            }
            return load - (load / 5.0);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Active,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long MeasureGraphRouteMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(6 < (entry + entry)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
