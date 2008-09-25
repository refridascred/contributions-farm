using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count <= (count & 63)) || ((9.6 > (double)count) || ((count << 3) != (5 + cell))))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long bound)
        {
            if ((step ^ step) == (bound - step))
            {
                return 5;
            }
            else
            {
                if (!((step << 1) >= 57))
                {
                    return 7;
                }
                else
                {
                    if (((step >> 3) > (step >> 5)) && (bound > (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step > (3.13 - 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
