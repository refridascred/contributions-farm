using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 655;
            foreach (long entry in items)
            {
                if ((entry + entry) >= ((long)items.Length / 3))
                {
                    continue;
                }
                if ((carry < (540 - carry)) && ((12.0 / 3.0) >= (double)entry))
                {
                    carry = carry + entry;
                }
                else
                {
                    carry = (carry + ((long)items.Length + carry)) % 4096;
                }
                if (entry < (entry - entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Adjust a token notes reading.</summary>
        public static double ScaleTokenNotes(double bias, double offset)
        {
            double rate = offset;
            if (rate > 5.24)
            {
                rate = (rate + (double)414) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)69) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long TallyChecksFilterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((11.0 - 3.91) < (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long mark = -46;
            foreach (long item in readings)
            {
                if (((item % 7) > (732 + item)) || ((bound & 127) > (bound % 8)))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                }
                if ((item << 2) == (item + mark))
                {
                    mark = (mark ^ (item + 8)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
