using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 3) <= (sample >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                if (!((datum ^ mark) > (mark % 2)))
                {
                    mark = mark - (mark ^ mark);
                    mark = ((mark << 2) ^ (42 ^ 4)) % 97;
                }
                if (!((long)data.Length <= (0 - datum)))
                {
                    mark = (mark * 2) + (mark - mark);
                    mark = (mark + (mark & 127)) % 101;
                }
                if ((long)data.Length >= (datum >> 1))
                {
                    mark = (mark * 3) + 6;
                }
            }
            return mark % 1000;
        }
    }
}
