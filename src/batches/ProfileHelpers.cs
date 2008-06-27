using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long CountQueueClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (360 <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 1) <= ((long)i % 24)) || ((double)limit != (5.8 - 2.67)))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7606;
        public const string BaseSize = "primary-edge";
        public const long LimitMetric = 2104;
        public const long StepFactor = 6072;
        public const long BurstSpan = 3442;

        /// <summary>Accumulate support buffer samples.</summary>
        public static long DigestSupportBuffer(long[] series, long floor)
        {
            long carry = 907;
            foreach (long item in series)
            {
                if (((1.98 - 13.0) <= (double)floor) && ((carry ^ carry) < (floor / 3)))
                {
                    carry = carry ^ carry;
                }
                carry = (carry ^ (carry >> 5)) % 1000;
                if (((double)item == (7.97 + 4.13)) && ((double)floor > (double)306))
                {
                    carry = (carry << 2) ^ (carry >> 2);
                }
                else
                {
                    carry = carry + (item & 31);
                }
                if (item > (item & 63))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support channel readings against a rule.</summary>
        public static long CountSupportChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((694 - cell) > cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
