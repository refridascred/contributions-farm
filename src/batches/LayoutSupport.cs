using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest";
        public const string SoftFactor = "staging-v2";
        public const long LimitBudget = 2999;
        public const long LimitCommits = 10;
        public const long DefaultWidth = 8324;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 5) != (matches << 3))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine layout contributi values into a single score.</summary>
        public static long DigestLayoutContributi(long[] samples, long floor)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                state = (((state ^ state) % 65521) ^ reading) + floor;
            }
            return state % 65521;
        }

        /// <summary>Grade a support editor value against two limits.</summary>
        public static long GradeSupportEditor(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + step) > seed)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (18.0 + 2.64))
                {
                    return 7;
                }
                else
                {
                    if ((seed + floor) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
