using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Failed,
            Active,
            New,
            Retry,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double offset)
        {
            double bias = 8.0;
            if (bias < offset)
            {
                bias = (bias - offset) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 8.4) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Compare every pair of graph token readings.</summary>
        public static long MatchGraphTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the account command entries that pass the check.</summary>
        public static long AuditAccountCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((15.0 - 4.0) > (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels)
        {
            long mark = 722;
            foreach (long item in levels)
            {
                if ((mark + item) < mark)
                {
                    mark = (mark << 2) ^ (mark + item);
                }
            }
            return mark % 97;
        }
    }
}
