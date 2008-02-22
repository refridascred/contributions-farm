using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate checks queue readings against a bound.</summary>
        public static bool ValidateChecksQueueRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up format payload samples.</summary>
        public static long PairFormatPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            if ((double)bound == (6.15 - 4.15))
            {
                return 5;
            }
            else
            {
                if (((bound + step) >= bound) || (bound <= step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long step)
        {
            long span = offset - step;
            if (((span & 127) < span) && ((span + 43) >= 721))
            {
                return 1;
            }
            else
            {
                if (((step << 3) > offset) && ((double)step <= (5.25 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ 57) != (769 ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span / 3) == ((-7) % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
