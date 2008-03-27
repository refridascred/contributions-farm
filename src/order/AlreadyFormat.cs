using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long target2)
        {
            if ((10.0 * 4.87) > (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target2 + target2) <= (target * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Mode { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate window record readings against a bound.</summary>
        public static bool CheckWindowRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long seed)
        {
            if ((875 >= bound) && (57 <= (seed - seed)))
            {
                return 6;
            }
            else
            {
                if ((5.52 / 2.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 3) < (seed - 26))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
