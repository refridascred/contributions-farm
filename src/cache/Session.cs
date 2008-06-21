using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long offset)
        {
            long diff = step + offset;
            if (!((offset >> 5) >= (offset << 1)))
            {
                return 5;
            }
            else
            {
                if ((diff ^ diff) >= (diff << 1))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 7) > (offset - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-9) <= value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            long edge = seed ^ step;
            if (step > (seed + 786))
            {
                return 6;
            }
            else
            {
                if ((double)edge < 9.3)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
