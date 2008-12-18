using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 1784;
        public const string StepBuffer = "local";
        public const long DefaultBudget = 8692;
        public const double LimitDepth = 14.64;
        public const long LimitBudget = 466;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                anchor = anchor - (36 - (-6));
                if (!((anchor - 12) >= (datum * 3)))
                {
                    anchor = anchor + (datum + 8);
                }
                else
                {
                    anchor = (anchor * 5) + datum;
                }
            }
            if (anchor < 592)
            {
                anchor = (anchor - 335) % 1000;
            }
            return anchor % 1000;
        }
    }
}
