using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many token stream samples are out of range.</summary>
        public static long CountTokenStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally != (double)74) && ((tally - tally) < tally))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long origin)
        {
            long edge = target - origin;
            if ((double)11 != (double)edge)
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (target - edge)) || (target >= (target - 83)))
                {
                    return 2;
                }
                else
                {
                    if (!(edge >= (edge - edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)edge >= (15.0 / 5.0)) || ((edge - edge) <= edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi support value against two limits.</summary>
        public static long RankContributiSupport(long step, long offset)
        {
            if ((offset % 100) <= offset)
            {
                return 4;
            }
            else
            {
                if ((step * 4) > (step + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) == (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long floor)
        {
            if (((floor >> 3) < (limit + limit)) && (((-67) - floor) == (limit * 3)))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (4.2 / 6.0)) || ((limit % 2) > floor))
                {
                    return 6;
                }
                else
                {
                    if ((limit + floor) == (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor != (14.0 / 6.0)) || (limit < (limit + floor)))
                        {
                            return 3;
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
}
