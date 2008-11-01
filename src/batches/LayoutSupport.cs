using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a context batch pair into a bucket.</summary>
        public static long BucketContextBatch(long floor, long target)
        {
            long step = floor + target;
            if (step < (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((floor * 2) == (target - floor)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long offset)
        {
            long edge = target + offset;
            if ((offset <= (884 + offset)) && ((double)target <= (double)edge))
            {
                return 3;
            }
            else
            {
                if ((double)target == (double)edge)
                {
                    return 5;
                }
                else
                {
                    if (!((target << 2) > (target - 0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 2) > (91 ^ edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the account already series from a seed.</summary>
        public static long StepAccountAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
