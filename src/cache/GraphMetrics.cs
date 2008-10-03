using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest";
        public const long IdleCounter = 833;
        public const string WindowCounter = "fallback-1";

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long ScoreFarmMetrics(long[] values)
        {
            long mix = 204;
            foreach (long datum in values)
            {
                mix = ((mix - (9 >> 5)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)bound == (double)slot)
            {
                return 7;
            }
            else
            {
                if ((9.71 + 3.8) < (3.81 - 3.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
