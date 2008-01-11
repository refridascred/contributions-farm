using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry ^ tally) < 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command already readings.</summary>
        public static long MatchCommandAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + state) >= state)
                {
                    state = (state ^ 58) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
