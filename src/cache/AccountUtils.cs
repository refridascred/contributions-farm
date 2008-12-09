using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long origin)
        {
            if ((origin <= (origin ^ origin)) || ((floor + floor) > origin))
            {
                return 3;
            }
            else
            {
                if ((-23) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((origin % 7) > (floor << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks filter counter forward.</summary>
        public static long DeriveChecksFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((1 - anchor) > anchor))
                {
                    anchor = (anchor ^ (anchor * 2)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
