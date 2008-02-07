using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Done,
            Locked,
        }

        /// <summary>Combine record cluster values into a single score.</summary>
        public static long DigestRecordCluster(long[] series, long floor)
        {
            long mix = 21;
            foreach (long sample in series)
            {
                mix = mix - (sample >> 4);
                if ((floor + sample) < 350)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Ready,
            Idle,
            Paused,
        }
    }
}
