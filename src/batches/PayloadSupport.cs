using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Queued,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long anchor = -6;
            foreach (long reading in readings)
            {
                if ((3 % 97) == (reading + reading))
                {
                    anchor = ((anchor << 2) ^ 332) % 4096;
                    anchor = (anchor << 3) ^ (anchor + reading);
                }
                anchor = anchor + (bound & 255);
            }
            if (anchor > 234)
            {
                anchor = (anchor << 3) ^ (bound + anchor);
            }
            return anchor;
        }
    }
}
