using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor * 2) < ((long)i ^ 5))
                {
                    anchor = ((anchor << 3) ^ (step + step)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
