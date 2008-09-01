using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4905;
        public const double DefaultAccount = 61.16;
        public const long MaxAccount = 2844;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - 17) != (seen ^ 989))
                {
                    seen = ((seen + 3) + cell) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data, long origin)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((((carry << 3) ^ (-3)) % 4096) + cell) + origin;
            }
            if (carry > 9)
            {
                carry = ((carry << 2) ^ (76 * 4)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long target)
        {
            long slot = limit ^ target;
            if ((-98) >= (slot % 24))
            {
                return 5;
            }
            else
            {
                if (!((limit << 1) != (6 % 100)))
                {
                    return 2;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target <= (13.0 * 4.4)))
                        {
                            return 3;
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
}
