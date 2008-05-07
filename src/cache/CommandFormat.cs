using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record farm values into a single score.</summary>
        public static long CombineRecordFarm(long[] levels, long target)
        {
            long carry = 804;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)carry)
                {
                    carry = (((carry * 2) + (datum / 6)) % 1000) - target;
                }
            }
            if (carry > 17)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Find the first filter editor entry that matches the target.</summary>
        public static long LocateFilterEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step > (16.0 + 10.0))
            {
                return 1;
            }
            else
            {
                if (!((target + step) <= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step) > step2) && ((double)target != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
