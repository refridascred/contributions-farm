using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long ScoreStatsQueue(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                if (((reading - 234) >= 86) || (9.9 <= (double)reading))
                {
                    anchor = ((anchor * 2) + (90 % 60)) % 65521;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = anchor - (anchor - reading);
                if ((reading & 127) < (anchor - anchor))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + (limit * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
