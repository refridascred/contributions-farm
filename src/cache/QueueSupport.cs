using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Queued,
            New,
            Failed,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long step)
        {
            long next = floor - step;
            if ((floor >> 4) >= (next - step))
            {
                return 4;
            }
            else
            {
                if ((next % 16) < next)
                {
                    return 3;
                }
                else
                {
                    if (!((next % 16) <= next))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= (step << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
