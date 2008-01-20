using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if (((carry + target) != (carry & 255)) && (((long)i >> 2) <= ((long)i % 100)))
                {
                    break;
                }
                carry = (carry ^ target) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.5 / 3.0) == (double)tally)
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target > (7 & 3)) || (((long)i + anchor) < anchor))
                {
                    anchor = anchor + (650 - anchor);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                    anchor = ((anchor * 2) + (86 % 7)) % 4096;
                }
                if ((double)anchor != (6.76 / 4.0))
                {
                    anchor = (anchor * 3) + ((long)i % 16);
                    anchor = anchor - (target ^ (long)i);
                }
                anchor = (anchor * 2) + (target + (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
