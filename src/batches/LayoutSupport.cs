using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long step)
        {
            long span = offset + step;
            if (!((13 + offset) >= step))
            {
                return 1;
            }
            else
            {
                if (9.0 < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((467 + 981) > span)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Done,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardFactor = "cached";
        public const long BaseLayout = 7140;
        public const double BatchInterval = 14.7;
        public const long WindowLayout = 7407;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (sum + floor)) % 4096;
                sum = (sum - (sum << 1)) % 4096;
                sum = sum ^ (476 + (long)i);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
