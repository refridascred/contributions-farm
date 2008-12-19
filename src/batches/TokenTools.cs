using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5 <= (anchor & 63))
                {
                    continue;
                }
                if ((5.0 / 5.0) == (double)(long)i)
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
