using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long MeasurePayloadStatsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (origin >> 3)) && ((datum & 15) < 821))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + 4) < (-716))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long mix = 764;
            foreach (long entry in samples)
            {
                if (((12.0 - 8.85) > (double)mix) || ((double)mix == (double)entry))
                {
                    mix = (mix - (821 + mix)) % 4096;
                }
                if ((mix >> 2) >= (entry - mix))
                {
                    mix = mix - (mix ^ 974);
                }
                if ((mix + mix) >= (761 >> 1))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long seed)
        {
            long slot = origin + seed;
            if (origin >= (seed / 8))
            {
                return 2;
            }
            else
            {
                if ((origin - (-5)) >= (slot % 7))
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin > (4.1 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin << 3) >= (seed % 64)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long offset)
        {
            if ((target > (offset - offset)) || ((offset - 2) >= target))
            {
                return 2;
            }
            else
            {
                if ((offset < (target & 3)) && ((1.6 * 5.6) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (target & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
