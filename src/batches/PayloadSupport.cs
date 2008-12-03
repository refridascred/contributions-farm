using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record layout readings.</summary>
        public static long ScoreRecordLayout(long[] levels, long step)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark - ((long)i & 255)) % 65521) + sample) - step;
                }
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long floor)
        {
            long edge = origin - floor;
            if (((2.8 * 8.9) >= (double)edge) && ((floor - 189) != (34 + edge)))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= 5.79)
                {
                    return 5;
                }
                else
                {
                    if ((edge ^ origin) > (edge & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
