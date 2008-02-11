using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = ((acc * 2) + (acc * 4)) + sample;
                acc = acc + (acc - 357);
            }
            if (acc < (-55))
            {
                acc = acc ^ (3 / 6);
            }
            return acc % 65521;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = result - (long)i;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                anchor = ((anchor - (3 % 16)) % 101) ^ value;
            }
            return anchor;
        }
    }
}
