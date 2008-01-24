using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = -3;
            foreach (long entry in samples)
            {
                mix = mix + (mix - (long)samples.Length);
                if ((mix >= entry) && ((entry + mix) == (29 - mix)))
                {
                    break;
                }
            }
            if (mix > 957)
            {
                mix = (mix - (918 >> 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long seed)
        {
            if ((floor + floor) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (seed < floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ 69) > floor)
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

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 903;
        public const long BatchRoute = 8982;
        public const long BaseFactor = 1289;
        public const long BaseRoute = 7537;
        public const long HardWidth = 1753;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long bound)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                if (((bound << 2) > (bound + sample)) || (carry >= (sample << 2)))
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                }
                if ((bound + sample) <= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Audit record batches readings against a rule.</summary>
        public static long CountRecordBatchesHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading % 12) < (bound + 0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
