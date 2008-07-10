using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long SortPayloadFormat(long step, long offset)
        {
            long delta = step - offset;
            if (((step / 6) != (step + offset)) && ((double)5 <= (double)delta))
            {
                return 5;
            }
            else
            {
                if ((7 >> 5) == (delta - delta))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)delta >= 1.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((bound >> 4) < (bound % 97))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                double bias = (double)total;
                if ((double)bound == (bias / 2.0))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate contributi stream readings against a bound.</summary>
        public static bool VerifyContributiStreamLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
