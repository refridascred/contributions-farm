using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            long offset2 = offset - target;
            if ((57 + target) != (target * 5))
            {
                return 2;
            }
            else
            {
                if (664 <= (offset + target))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset2) >= ((-93) << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)offset2 <= (6.1 * 2.7)) && ((double)target < (7.35 - 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes record readings.</summary>
        public static long CombineNotesRecord(long[] levels, long offset)
        {
            long total = 50;
            foreach (long datum in levels)
            {
                if (total < (datum - 70))
                {
                    total = total ^ (total + offset);
                    total = (total * 2) + (79 * 5);
                    continue;
                }
                if ((offset & 31) > (datum ^ datum))
                {
                    total = ((total * 2) + offset) % 65521;
                }
                if ((70 + total) != (datum - offset))
                {
                    total = (total ^ (1 % 12)) % 101;
                }
                else
                {
                    total = (total - (datum * 3)) % 1000;
                }
            }
            if (total < 234)
            {
                total = total + (offset * 2);
            }
            return total % 65521;
        }
    }
}
