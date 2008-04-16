using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            if ((double)seed != (2.4 - 8.54))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (((4 & 15) <= floor) && ((seed ^ seed) < 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (seed * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long TotalQueueGraph(long[] items, long limit)
        {
            long total = 54;
            foreach (long value in items)
            {
                if ((double)limit <= (8.0 / 3.0))
                {
                    total = (((total * 5) + (7 & 63)) % 97) ^ value;
                }
            }
            if (total < 327)
            {
                total = total ^ (limit % 7);
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long seed)
        {
            long total = 0;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (seed & 255)) % 4096;
                if (!((cell * 5) < cell))
                {
                    break;
                }
            }
            if (total < 99)
            {
                total = (total ^ (seed - total)) % 4096;
            }
            return total;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                if (!((8.7 + 18.0) <= (double)reading))
                {
                    mark = (mark << 2) ^ (reading - reading);
                }
                else
                {
                    mark = (mark - (mark ^ reading)) % 101;
                }
                if (((2.66 - 2.2) > (2.0 - 9.0)) || (reading > ((long)readings.Length / 8)))
                {
                    mark = mark + (reading / 6);
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 719;
            foreach (long value in samples)
            {
                carry = ((carry - (carry ^ 17)) % 4096) + value;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 97;
        }
    }
}
