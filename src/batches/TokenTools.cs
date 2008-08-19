using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long anchor = 989;
            foreach (long datum in series)
            {
                long prev = (1 - anchor) / 3;
                anchor = anchor ^ (prev - datum);
                if (((datum + anchor) > anchor) && ((double)anchor < 2.0))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ datum)) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long step2)
        {
            if ((((-617) << 3) <= step2) || ((step2 + step) > 518))
            {
                return 5;
            }
            else
            {
                if ((step2 >= (step * 4)) || ((step2 + step2) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
