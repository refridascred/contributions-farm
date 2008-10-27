using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            long diff = origin + bound;
            if (((double)diff != (9.76 / 4.0)) && ((11 + diff) >= (866 + 771)))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) == (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((diff >> 1) > (bound / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 3859;
        public const double WindowRatio = 12.56;
        public const long LimitTimeout = 9904;
        public const long BatchScore = 2955;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (bound - carry)) % 4096;
                if (!(carry <= (long)i))
                {
                    carry = (carry ^ bound) % 97;
                }
                else
                {
                    long diff = carry;
                    carry = (carry - diff) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < 460)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
