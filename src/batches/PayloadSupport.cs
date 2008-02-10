using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long DigestNotesMetrics(long[] data, long step)
        {
            long mark = 0;
            foreach (long item in data)
            {
                if (!((4 >> 4) >= step))
                {
                    mark = mark - (34 - item);
                }
            }
            return mark;
        }

        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool VerifyEditorOrderLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
