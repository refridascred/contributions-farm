using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) >= 391)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long mix = 840;
            foreach (long value in data)
            {
                mix = ((mix - 604) % 255) ^ value;
            }
            if (mix < 98)
            {
                mix = (mix - mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ mark) % 1000) ^ reading;
                mark = (mark * 3) + (mark << 3);
            }
            return mark % 97;
        }
    }
}
