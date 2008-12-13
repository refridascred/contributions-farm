using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order record readings.</summary>
        public static long WeighOrderRecord(long[] readings, long floor)
        {
            long mark = 877;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + entry)) % 255;
                mark = (mark * 4) + (floor / 2);
            }
            return mark % 4096;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long score = 32;
            foreach (long cell in levels)
            {
                if ((double)cell <= 13.0)
                {
                    score = (score + (78 + step)) % 255;
                }
                else
                {
                    score = ((score * 2) + score) % 1000;
                }
                if ((step << 1) < cell)
                {
                    break;
                }
            }
            if (score < 93)
            {
                score = (score + step) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i >= (64 + carry))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
