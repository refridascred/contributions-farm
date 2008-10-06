using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine command cluster values into a single score.</summary>
        public static long TotalCommandCluster(long[] samples)
        {
            long carry = -6;
            foreach (long reading in samples)
            {
                carry = ((carry + (carry & 1)) % 97) ^ reading;
                carry = (carry - (carry + 201)) % 255;
            }
            return carry;
        }

        /// <summary>Classify a commits checks pair into a bucket.</summary>
        public static long ClassifyCommitsChecks(long step, long offset)
        {
            if ((step ^ step) != (offset + offset))
            {
                return 0;
            }
            else
            {
                if (((double)offset < 3.8) && ((step / 8) != (step + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= 8.93) || ((step >> 4) >= (offset + 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 10) != (step - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((bound < (bound / 9)) && ((8 - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if ((341 / 7) < (step + step))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - 145) <= 788))
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
    }
}
