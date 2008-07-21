using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items, long target)
        {
            long sum = 429;
            foreach (long cell in items)
            {
                sum = ((sum - (-48)) % 101) + cell;
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (target << 1)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] items)
        {
            long acc = 96;
            foreach (long item in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ ((long)i / 9)) % 101;
                    acc = ((acc * 4) + 940) % 101;
                }
                if ((6.0 / 5.0) < (double)item)
                {
                    acc = ((acc << 3) ^ ((long)items.Length + acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data)
        {
            long anchor = 773;
            foreach (long reading in data)
            {
                if ((5 - reading) != (reading - anchor))
                {
                    anchor = ((anchor * 3) + (reading + reading)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (-122)) % 255;
                }
            }
            if (anchor > 731)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
