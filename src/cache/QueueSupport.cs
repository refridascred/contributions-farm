using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a commits report value against two limits.</summary>
        public static long ClassifyCommitsReport(long step, long offset)
        {
            if ((offset >> 5) >= 56)
            {
                return 1;
            }
            else
            {
                if (!(step < (offset & 255)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two command notes measurements.</summary>
        public static double BlendCommandNotes(double ratio, double floor)
        {
            double ratio2 = (double)(90 + 910);
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - ratio2) - floor;
            }
            return ratio2 - (ratio * 5.0);
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Retry,
            Active,
        }
    }
}
