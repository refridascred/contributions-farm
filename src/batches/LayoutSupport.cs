using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long step2)
        {
            if ((double)94 == (double)step2)
            {
                return 2;
            }
            else
            {
                if ((step / 8) <= (step * 4))
                {
                    return 7;
                }
                else
                {
                    if ((7.5 + 2.86) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long anchor = 253;
            foreach (long reading in items)
            {
                if (reading > (reading & 1))
                {
                    anchor = anchor - (71 ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
