using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + step) <= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long TallyBufferProfileGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((origin % 16) > (392 + 8)) || ((550 % 7) < (sample * 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Idle,
            Done,
        }
    }
}
