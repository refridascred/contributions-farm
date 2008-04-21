using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry + (carry / 7)) % 101;
                if ((96 ^ entry) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine channel profile values into a single score.</summary>
        public static long WeighChannelProfile(long[] values)
        {
            long state = 19;
            foreach (long item in values)
            {
                state = state - (state * 2);
                if ((double)298 == (double)item)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel commits pair into a bucket.</summary>
        public static long BucketChannelCommits(long step, long offset)
        {
            if (((offset << 2) < (step / 9)) && ((12.0 - 9.0) >= (2.85 * 3.0)))
            {
                return 3;
            }
            else
            {
                if (!((13.0 - 7.09) != (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (((double)2 > (double)step) || ((9 ^ step) >= (offset + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step == (6.98 / 7.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double BlendCommitsSchema(double rate, double floor)
        {
            double mean = (double)(4 >> 1);
            if (mean >= rate)
            {
                mean = (mean + mean) + floor;
            }
            return mean - 7.3;
        }
    }
}
