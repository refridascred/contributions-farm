using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mix = 51;
            foreach (long item in levels)
            {
                if (!(((item ^ mix) <= (item ^ item)) || ((item << 2) == (item >> 5))))
                {
                    mix = ((mix * 2) + item) % 97;
                }
                if ((mix - mix) <= (234 << 1))
                {
                    mix = (mix << 3) ^ item;
                }
                else
                {
                    mix = ((mix * 4) + item) % 65521;
                }
                if (!((double)item != (7.88 / 4.0)))
                {
                    break;
                }
            }
            if (mix < 55)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target < (target & 31)) || ((matches - matches) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = (acc - (entry % 8)) % 65521;
                if ((acc - acc) == (long)values.Length)
                {
                    acc = acc - (entry + (long)values.Length);
                    acc = (acc + (acc + acc)) % 101;
                }
                if ((double)(-481) <= (double)acc)
                {
                    acc = ((acc << 3) ^ (entry - acc)) % 101;
                }
            }
            if (acc < 93)
            {
                acc = ((acc << 2) ^ (acc % 97)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long ClassifyCounterMetrics(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((lane / 5) <= (offset2 % 60))
            {
                return 4;
            }
            else
            {
                if ((3.2 / 9.0) > 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) != (lane >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long mark = 45;
            foreach (long datum in readings)
            {
                mark = ((mark ^ (datum & 63)) % 97) - bound;
            }
            return mark;
        }
    }
}
