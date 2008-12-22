using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter graph counter forward.</summary>
        public static long RollFilterGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ limit;
                if ((19.0 + 5.0) < (double)mix)
                {
                    mix = (mix * 2) + (limit & 3);
                    mix = ((mix << 3) ^ ((long)i + limit)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long mix = 46;
            foreach (long datum in values)
            {
                if ((datum << 3) != (675 / 6))
                {
                    mix = (mix + (datum & 31)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Check that every queue schema entry stays within the limit.</summary>
        public static bool ValidateQueueSchemaLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Paused,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Roll a profile support counter forward.</summary>
        public static long DeriveProfileSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark << 1) > (mark * 4)))
                {
                    mark = ((mark * 3) + (mark & 15)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long offset, long target)
        {
            long delta = offset ^ target;
            if ((offset & 15) <= (offset + target))
            {
                return 4;
            }
            else
            {
                if ((5 + offset) > delta)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target >= 3.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)target == (double)delta) || ((offset + offset) > target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
