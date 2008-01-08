using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Idle,
            New,
            Paused,
            Done,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long delta = offset - seed;
            if (((double)delta != (double)80) && (seed < (offset ^ seed)))
            {
                return 2;
            }
            else
            {
                if (((double)offset <= (2.69 / 5.0)) || (((-7) + seed) < (offset >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (((seed / 8) < (delta >> 1)) || ((offset + seed) >= (509 * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((delta ^ offset) == (offset & 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            New,
            Locked,
            Ready,
            Draft,
        }
    }
}
