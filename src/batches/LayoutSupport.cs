using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if ((score << 3) == (8 - score))
                {
                    score = ((score - (score + score)) - cell) - floor;
                }
            }
            return score;
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

        /// <summary>Digest a series of contributi context entries.</summary>
        public static long TotalContributiContext(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = sum - (entry + entry);
            }
            return sum;
        }
    }
}
