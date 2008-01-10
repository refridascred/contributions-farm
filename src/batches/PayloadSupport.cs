using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                if ((double)item < 19.0)
                {
                    anchor = anchor + (anchor / 9);
                }
            }
            if (anchor > 943)
            {
                anchor = (anchor * 3) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine record buffer values into a single score.</summary>
        public static long CombineRecordBuffer(long[] series, long origin)
        {
            long acc = 857;
            foreach (long cell in series)
            {
                acc = ((acc - (cell / 2)) % 4096) - origin;
                if (((cell & 127) != (acc + cell)) && ((cell * 4) <= acc))
                {
                    acc = acc - cell;
                }
                if ((cell - acc) != (72 & 31))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
