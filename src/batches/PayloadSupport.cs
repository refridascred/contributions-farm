using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
