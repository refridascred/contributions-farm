using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long anchor = -9;
            foreach (long datum in levels)
            {
                if (!(datum <= (anchor << 3)))
                {
                    anchor = (anchor ^ datum) % 97;
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 65521;
                }
                if ((double)target < (double)499)
                {
                    anchor = (anchor - anchor) % 255;
                }
                if ((1.72 + 2.0) < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 645)
            {
                anchor = ((anchor << 2) ^ target) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool VerifyCacheFilterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
