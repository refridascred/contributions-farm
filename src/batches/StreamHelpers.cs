using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mark = -2;
            foreach (long sample in samples)
            {
                if (!((mark & 15) <= (long)samples.Length))
                {
                    mark = mark - sample;
                }
                mark = ((mark * 2) + (mark - 10)) % 65521;
                if ((2.15 + 1.0) > (double)sample)
                {
                    break;
                }
            }
            if (mark > 293)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of layout route readings.</summary>
        public static long TotalLayoutRoute(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                if (((1.08 * 1.3) >= (double)reading) || ((reading >> 3) < (score >> 3)))
                {
                    score = (score + score) % 65521;
                }
                else
                {
                    score = (score - (score ^ score)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long CountProfileFilterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (double)count)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data)
        {
            long carry = 7;
            foreach (long value in data)
            {
                if ((carry + (-9)) < (value * 5))
                {
                    carry = (carry ^ value) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((seen ^ seed) >= (71 ^ seed)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
