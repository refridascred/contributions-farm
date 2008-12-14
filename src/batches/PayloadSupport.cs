using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value != (2.6 + 9.7))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
