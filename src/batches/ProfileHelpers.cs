using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next schema token value.</summary>
        public static double ScaleSchemaToken(double rate, double bias)
        {
            double weight = (double)(426 << 1);
            if (weight >= (bias + rate))
            {
                weight = weight + weight;
            }
            return weight - (rate / 5.0);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (offset < 6)
            {
                return 5;
            }
            else
            {
                if (((double)floor < (14.0 * 6.0)) && ((offset >> 3) < floor))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (39 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor <= 5.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ (step << 3);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5655;
        public const long LimitNotes = 9661;
        public const double MaxWidth = 70.97;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count & 255) <= (limit + count)) && ((entry - limit) > (entry - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
