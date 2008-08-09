using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Scale a command layout figure with a bias.</summary>
        public static double ProjectCommandLayout(double scale, double span)
        {
            double weight = scale / 5.0;
            if (weight < 1.0)
            {
                weight = (weight - (weight + weight)) + span;
            }
            return weight - (9.0 / 8.0);
        }

        /// <summary>Match up support record samples.</summary>
        public static long PairSupportRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
