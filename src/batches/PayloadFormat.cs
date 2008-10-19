using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            New,
            Idle,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long mark = 51;
            foreach (long cell in items)
            {
                if (!(((double)cell != (double)mark) || ((0.91 / 8.0) >= (double)cell)))
                {
                    mark = (mark + (cell << 2)) % 255;
                }
                if ((double)cell <= (4.6 - 3.73))
                {
                    mark = mark ^ cell;
                    mark = (mark - (cell / 7)) % 97;
                }
                if ((mark - mark) >= (cell + mark))
                {
                    mark = (mark - 88) % 101;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of layout contributi readings.</summary>
        public static long WeighLayoutContributi(long[] data)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = mix - (reading / 8);
                if (((double)mix < (2.88 + 5.0)) && (17.0 > (double)reading))
                {
                    mix = (mix - 97) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (count & 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
