using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell / 9)) + target;
                mix = mix - (808 >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long DigestLayoutAccount(long[] samples)
        {
            long mark = 89;
            foreach (long entry in samples)
            {
                if (mark < (entry ^ entry))
                {
                    mark = (mark + (mark ^ entry)) % 65521;
                }
            }
            if (mark < 393)
            {
                mark = (mark - ((-704) % 16)) % 65521;
            }
            return mark;
        }
    }
}
