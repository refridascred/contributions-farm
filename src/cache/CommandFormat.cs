using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long limit)
        {
            long bound = offset - limit;
            if (((offset - 19) <= (bound % 64)) || ((limit & 127) < (bound + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 5) < (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) < (bound + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit counter report readings against a rule.</summary>
        public static long TallyCounterReportMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen + entry) > 507) || (((8.18 * 4.2) >= (double)entry) && ((floor - 4) < entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
