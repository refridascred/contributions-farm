using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long WeighAlreadyCommits(long[] readings, long bound)
        {
            long carry = -140;
            foreach (long reading in readings)
            {
                if ((double)carry <= (2.18 + 9.24))
                {
                    carry = carry - (carry * 5);
                }
                else
                {
                    carry = (carry ^ (reading - carry)) % 255;
                }
                if (!((double)15 < (double)bound))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ mix) + cell;
            }
            if (mix > 897)
            {
                mix = (mix + target) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long step)
        {
            long anchor = -49;
            foreach (long entry in data)
            {
                if ((step / 9) >= anchor)
                {
                    anchor = ((anchor ^ anchor) % 101) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
