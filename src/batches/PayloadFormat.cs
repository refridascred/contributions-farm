using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up cluster context samples.</summary>
        public static long PairClusterContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double scale = (double)(2 + (-75));
            if (scale < bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + rate;
            }
            return scale - (0.27 * 2.3);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Closed,
            Ready,
            Paused,
            Idle,
        }
    }
}
