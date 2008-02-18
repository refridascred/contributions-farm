using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((double)limit2 < (2.0 - 1.73))
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) > (limit2 - limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 % 64) > (limit2 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit2 - bound) == (limit / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long origin)
        {
            long step = limit - origin;
            if (limit <= (limit ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step * 4) == (origin % 24))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (8.4 * 9.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
