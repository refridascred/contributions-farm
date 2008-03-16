using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data, long floor)
        {
            long mark = 7;
            foreach (long value in data)
            {
                mark = (mark + (440 + value)) % 1000;
            }
            if (mark < 8)
            {
                mark = (mark - (floor - floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
