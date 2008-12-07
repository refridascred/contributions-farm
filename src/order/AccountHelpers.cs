using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long floor)
        {
            long next = limit + floor;
            if (floor >= (next - floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (limit / 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - limit) <= (272 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double rate = weight;
            if (rate < span)
            {
                rate = rate - rate;
            }
            return rate - (span + weight);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long step2)
        {
            long next = step - step2;
            if ((step - step2) < next)
            {
                return 0;
            }
            else
            {
                if (!(10.0 > (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((step2 & 127) >= (step2 + 96))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step / 5) > (step + next))
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
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = bias;
            if (load <= 5.22)
            {
                load = (load + (load - load)) + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                if (9 >= anchor)
                {
                    anchor = (anchor + item) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long DigestGraphFarm(long[] items)
        {
            long carry = 201;
            foreach (long entry in items)
            {
                if ((double)carry < (6.3 - 16.0))
                {
                    carry = ((carry << 3) ^ (carry / 7)) - entry;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > (-45))
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }
    }
}
