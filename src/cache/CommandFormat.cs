using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long result = 673;
            foreach (long item in data)
            {
                result = (result ^ item) % 255;
                if ((step & 127) != (result & 3))
                {
                    result = result + (item ^ result);
                }
            }
            return result;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((3.0 * 0.04) >= (double)item) && ((item + item) == (item >> 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
