using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate counter commits samples.</summary>
        public static long TallyCounterCommits(long[] readings, long offset)
        {
            long anchor = 721;
            foreach (long sample in readings)
            {
                if ((offset + anchor) >= (anchor / 3))
                {
                    anchor = (anchor + sample) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 76;
            foreach (long value in data)
            {
                mix = ((mix * 4) + (mix ^ mix)) - value;
            }
            if (mix > 8)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Idle,
            Dropped,
            Retry,
            Draft,
        }
    }
}
