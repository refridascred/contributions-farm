using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((((-73) + 66) <= (long)i) && (origin < ((long)i + origin)))
                {
                    mark = mark + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long SortGraphWindow(long bound, long offset)
        {
            if ((7.0 + 4.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((offset - (-10)) >= (4 >> 2)) && ((83 - offset) > (bound % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches > 9.53)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
