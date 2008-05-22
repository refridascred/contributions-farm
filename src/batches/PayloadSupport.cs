using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if ((double)limit != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 8) != (limit - offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
