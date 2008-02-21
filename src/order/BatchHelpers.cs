using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((mark + origin) > ((long)i & 7)))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank contributi order input into a small class.</summary>
        public static long SortContributiOrder(long bound, long step)
        {
            long span = bound ^ step;
            if ((bound * 3) != (918 & 1))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (13.0 * 2.6)) || ((922 / 8) <= (bound * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - span) < (span + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the support editor series from a seed.</summary>
        public static long SeriesSupportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (long)i) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
