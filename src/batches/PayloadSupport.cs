using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowSpan = 6.8;
        public const long CacheToken = 2799;
        public const long BatchToken = 4500;

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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
