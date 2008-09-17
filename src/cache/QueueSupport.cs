using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long mix = 368;
            foreach (long cell in data)
            {
                mix = (mix + mix) + cell;
            }
            return mix % 1000;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool VerifyClusterBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + 570) < (matches + 12))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
