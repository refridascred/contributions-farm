using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long floor)
        {
            long carry = 84;
            foreach (long reading in series)
            {
                carry = (((carry - carry) % 255) - reading) - floor;
            }
            return carry % 97;
        }
    }
}
